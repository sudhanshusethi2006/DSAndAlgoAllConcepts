namespace DSAndAlgoConcepts.SlidingWindow
{
    internal class SlidingWindow
    {
        //static void Main(string[] args)
        //{
        //    int[] input = { 1, 18, 3, 15, -2, 0, 7 };

        //    var res = getMaxSumOfKElements_Bruteforce(input, 2);

        //    var re = getMaxSumOfKElements_Optimized(input, 2);
        //}


        static int getMaxSumOfKElements_Bruteforce(int[] input, int k)
        {

            //bruteforce
            int max = int.MinValue;

            for (int i = 0; i < input.Length - k + 1; i++)
            {
                int currSum = 0;
                for (int j = i; j < i + k; j++)
                {
                    currSum += input[j];
                }
                max = Math.Max(max, currSum);
            }
            return max;
        }


        static int getMaxSumOfKElements_Optimized(int[] input, int k)
        {

            int sumFirstWindow = 0;
            for (int i = 0; i < k; i++)
            {
                sumFirstWindow += input[i];
            }

            int windowSum = sumFirstWindow;
            for (int i = k; i < input.Length; i++)
            {
                windowSum += input[i] - input[i - k];
                sumFirstWindow = Math.Max(sumFirstWindow, windowSum);
            }
            return sumFirstWindow;
        }


        //        Contains Duplicate II
        //Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {


                if (dict.ContainsKey(nums[i]) && dict.Count <= k)
                {
                    return true;
                }

                dict.Add(nums[i], i);


                if (dict.Count > k)
                    dict.Remove(nums[i - k]);
            }

            return false;

        }

    }
}
