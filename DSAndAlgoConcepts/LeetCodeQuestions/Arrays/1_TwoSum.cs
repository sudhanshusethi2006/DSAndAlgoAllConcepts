namespace DSAndAlgoConcepts.LeetCodeQuestions.Arrays
{
    internal class _1_TwoSum
    {
        //static void Main(string[] args)
        //{
        //    var nums = new int[] { 3, 3 };
        //    TwoSum(nums, 7);
        //}
        static public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (dict.ContainsKey(diff))
                    return new int[] { dict[diff], i };
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }
            return new int[] { };
        }

        public int[] TwoSum_BruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        return new int[] { i, j };
                }
            }
            return new int[] { };
        }
    }


}
