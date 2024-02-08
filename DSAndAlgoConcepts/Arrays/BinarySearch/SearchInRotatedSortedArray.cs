namespace DSAndAlgoConcepts.Arrays.BinarySearch
{
    internal class SearchInRotatedSortedArray
    {
        //static void Main(string[] args)
        //{
        //    int[] nums = new int[] { 3, 1 };
        //    var res = Search(nums, 1);
        //    Console.WriteLine(res);
        //}
        static public int Search(int[] nums, int target)
        {

            var pivotIndex = FindPivot(nums);

            if (nums[pivotIndex] == target) return pivotIndex;
            if (target >= nums[pivotIndex] && target <= nums[nums.Length - 1])
                return BinarySearch(nums, pivotIndex, nums.Length - 1, target);
            else
                return BinarySearch(nums, 0, pivotIndex, target);


        }

        static int BinarySearch(int[] nums, int start, int end, int target)
        {
            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (nums[mid] == target) return mid;
                if (target > nums[mid])
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return -1;
        }

        static private int FindPivot(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start < end)
            {
                int mid = (start + end) / 2;

                if (mid > 0 && nums[mid] < nums[mid - 1])
                {
                    return mid;
                }
                if (nums[mid] > nums[start] && nums[mid] > nums[end])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return start;
        }

    }
}
