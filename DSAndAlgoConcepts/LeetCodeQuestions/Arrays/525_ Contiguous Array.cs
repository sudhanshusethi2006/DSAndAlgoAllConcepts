namespace DSAndAlgoConcepts.LeetCodeQuestions.Arrays
{
    internal class _525__Contiguous_Array
    {
        //        Given a binary array nums, return the maximum length of a contiguous subarray with an equal number of 0 and 1.



        //Example 1:

        //Input: nums = [0,1]
        //        Output: 2
        //Explanation: [0, 1] is the longest contiguous subarray with an equal number of 0 and 1.
        //Example 2:

        //Input: nums = [0,1,0]
        //        Output: 2
        //Explanation: [0, 1] (or[1, 0]) is a longest contiguous subarray with equal number of 0 and 1.

        //static void Main(string[] args)
        //{
        //    int[] nums = { 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0 };
        //    var ans = FindMaxLength_Bruteforce(nums);

        //    var max = FindMaxLength(nums);
        //}

        public static int FindMaxLength_Bruteforce(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int count0 = 0;
                int count1 = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] == 0)
                        count0++;
                    else
                        count1++;

                    if (count0 == count1)
                    {
                        count = Math.Max(count, j - i + 1);
                    }
                }
            }

            return count;
        }


        //optimized
        public static int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            counts.Add(0, -1);
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1) count++;
                else count--;

                if (counts.ContainsKey(count))
                {
                    maxCount = Math.Max(maxCount, i - counts[count]);
                }
                else
                    counts.Add(count, i);
            }

            return maxCount;



        }


    }
}
