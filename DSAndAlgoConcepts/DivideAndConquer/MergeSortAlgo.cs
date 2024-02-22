namespace DSAndAlgoConcepts.DivideAndConquer
{
    internal class MergeSortAlgo
    {
        //static void Main(string[] args)
        //{
        //    var arr = new int[] { 6, 3, 9, 5, 2, 8 };
        //    MergeSort(arr, 0, arr.Length - 1);

        //}

        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right) return;

            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);  //left
            MergeSort(arr, mid + 1, right); // right 
            Merge(arr, left, mid, right);

        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] tempArray = new int[right - left + 1];
            int left_iterator = left;
            int right_iterator = mid + 1;
            int k = 0;// iterator of the  temporary array

            while (left_iterator <= mid && right_iterator <= right)
            {
                if (arr[left_iterator] < arr[right_iterator])
                {
                    tempArray[k] = arr[left_iterator];
                    left_iterator++;
                }
                else
                {
                    tempArray[k] = arr[right_iterator];
                    right_iterator++;
                }
                k++;
            }

            //left part
            while (left_iterator <= mid)
            {
                tempArray[k++] = arr[left_iterator++];
            }

            //right part
            while (right_iterator <= right)
            {
                tempArray[k++] = arr[right_iterator++];
            }


            // copy to original array

            // Array.Copy(tempArray, arr, tempArray.Length);

            //or 
            for (k = 0, left_iterator = left; k < tempArray.Length; k++, left_iterator++)
            {
                arr[left_iterator] = tempArray[k];
            }

        }


    }
}
