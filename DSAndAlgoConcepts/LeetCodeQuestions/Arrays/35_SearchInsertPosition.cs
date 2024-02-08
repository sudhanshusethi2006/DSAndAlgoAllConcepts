namespace DSAndAlgoConcepts.LeetCodeQuestions.Arrays
{
    internal class _35_SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {

            int p = 0;
            int q = nums.Length - 1;
            while (p < q)
            {
                int mid = (p + q) / 2;
                if (nums[mid] == target)
                    return mid;

                if (nums[mid] > target)
                {
                    q = mid - 1;
                }
                else
                {
                    p = mid + 1;
                }
            }
            if (nums[p] < target)
                return p + 1;

            return p;

        }
    }
}
