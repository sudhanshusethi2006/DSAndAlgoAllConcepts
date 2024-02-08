namespace DSAndAlgoConcepts.BinarySearch
{

    // only for sorted array
    internal class TwoSumWithO_N_Time
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 2, 3, 4 };
        //    var res = TwoSum(arr, 6);
        //}

        // if the given arrays are sorted
        public static int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                int second = target - nums[i];
                var secondIndex = FindUsingBinarySearch(nums, second, i);
                if (secondIndex > -1)
                    return new int[] { i, secondIndex };
            }
            return new int[] { };
        }

        private static int FindUsingBinarySearch(int[] arr, int item, int currentIndex)
        {
            int p = 0;
            int q = arr.Length - 1;

            while (p <= q)
            {
                int mid = (p + q) / 2;
                if (mid == currentIndex) { p++; continue; }
                if (arr[mid] > item)
                {
                    q = mid - 1;
                }
                if (arr[mid] < item)
                {
                    p = mid + 1;
                }
                if (arr[mid] == item)
                {
                    return mid;
                }

            }
            return -1;
        }
    }
}
