namespace DSAndAlgoConcepts.DivideAndConquer
{
    //Given an array of integers.Find theInversion Countin the array. 
    //(HARD) InversionCount:Foranarray,inversion count indicates how far(orclose)the array is from being sorted.
    //If the array is already sorted then the inversion count is 0.
    //If an array is sorted in the reverse order then the inversion count is the maximum.Formally, 
    //two elements a[i] and a[j] form an inversion if a[i] > a[j] and i<j.Sample Input 1: N = 5, arr[] = { 2, 4, 1, 3, 5}
    //Sample Output 1: 3, because it has 3 inversions -(2, 1), (4, 1), (4, 3).
    //https://www.geeksforgeeks.org/inversion-count-in-array-using-merge-sort/
    internal class InversionCountInTheArray
    {
        //static void Main(string[] args)
        //{
        //    var arr = new int[] { 70, 90, 10, 50, 40, 20, 30, 80 };

        //    var count = UsingMergeSort(arr, 0, arr.Length - 1);
        //}

        static int UsingMergeSort(int[] nums, int left, int right)
        {
            int count = 0;
            if (left >= right) return 0;
            int mid = left + (right - left) / 2;

            count += UsingMergeSort(nums, left, mid);
            count += UsingMergeSort(nums, mid + 1, right);
            count += Merge(nums, left, mid, right);
            return count;
        }

        static int Merge(int[] nums, int left, int mid, int right)
        {
            int count = 0;
            int i = left;
            int j = mid + 1;
            int k = 0;

            var temp = new int[right - left + 1];
            while (i <= mid && j <= right)
            {
                if (nums[i] < nums[j])
                {
                    temp[k++] = nums[i++];


                }
                else
                {
                    temp[k++] = nums[j++];
                    count = count + (mid - i);
                }


            }

            while (i <= mid)
            {
                temp[k++] = nums[i++];
            }

            while (j <= right)
            {
                temp[k++] = nums[j++];
            }

            for (i = left, k = 0; i <= right; i++, k++)
                nums[i] = temp[k];

            return count;
        }
    }
}
