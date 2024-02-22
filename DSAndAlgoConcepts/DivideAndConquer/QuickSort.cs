namespace DSAndAlgoConcepts.DivideAndConquer
{
    internal class QuickSortAlgo
    {
        //static void Main(string[] args)
        //{

        //}

        static void QuickSort(int[] arr, int start, int end)
        {

            if (start >= end) { return; }
            int pivotIndex = Partition(arr, start, end);
            QuickSort(arr, start, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, end);


        }

        static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    //swap
                    int temp2 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp2;
                }
            }

            i++;

            //swap
            int temp = pivot;
            arr[end] = arr[i];
            arr[i] = temp;

            return i;
        }
    }
}
