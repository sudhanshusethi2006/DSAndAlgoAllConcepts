namespace DSAndAlgoConcepts.LeetCodeQuestions.Arrays
{
    internal class _15_3Sum
    {
        //static void Main(string[] args)
        //{
        //    ThreeSum(new int[] { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 });
        //}
        public static IList<IList<int>> ThreeSum_BruteForce(int[] nums)
        {
            var ans = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (k > j + 1 && nums[k] == nums[k - 1]) continue;
                        if (nums[i] + nums[j] + nums[k] == 0)

                            ans.Add(new List<int>() { nums[i], nums[j], nums[k] });
                    }
                }
            }
            return ans;
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var ans = new List<IList<int>>();
            Array.Sort(nums);


            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int second = i + 1;
                int third = nums.Length - 1;

                while (second < third)
                {
                    if (nums[i] + nums[second] + nums[third] == 0)
                    {
                        ans.Add(new List<int> { nums[i], nums[second], nums[third] });
                        while (second < third && (nums[second] == nums[second + 1]))
                        {
                            second++;
                        }
                        while (second < third && (nums[third] == nums[third - 1]))
                        {
                            third--;
                        }
                        second++;
                        third--;
                    }
                    else if (nums[i] + nums[second] + nums[third] < 0)
                        second++;

                    else
                        third--;
                }
            }

            return ans;
        }




    }
}
