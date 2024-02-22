namespace DSAndAlgoConcepts.Sorting
{
    internal class QuickSort
    {
        //static void Main(string[] args)
        //{
        //    var arr = new int[] { 70, 30, 50, 60, 80, 90, 10, 60 };
        //    Quick_Sort(arr, 0, arr.Length - 1);
        //}

        static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left >= right) { return; }
            int pivot = ParitioningAlgorithm(arr, left, right);
            Quick_Sort(arr, left, pivot - 1);
            Quick_Sort(arr, pivot + 1, right);

        }

        // Partioning Algo
        static int ParitioningAlgorithm(int[] nums, int left, int right)
        {
            int pivot = nums[right];
            int j = left;
            for (int i = left; i <= right; i++)
            {
                if (nums[i] <= pivot)
                {
                    Swap(nums, i, j);
                    j++;
                }

            }
            return j - 1;
        }

        static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }





    }
}
