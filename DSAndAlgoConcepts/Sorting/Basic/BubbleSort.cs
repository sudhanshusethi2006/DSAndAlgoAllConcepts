namespace DSAndAlgoConcepts.Sorting.Basic
{
    internal class BubbleSortAlgo
    {
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        //static void Main(string[] args)
        //{
        //    int[] arr = { 30, 25, 16, 20, 1 };
        //    BubbleSort(arr);
        //    Console.WriteLine(string.Join(",", arr));
        //}
    }
}
