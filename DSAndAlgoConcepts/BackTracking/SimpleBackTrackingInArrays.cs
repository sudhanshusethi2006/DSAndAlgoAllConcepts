namespace DSAndAlgoConcepts.BackTracking
{
    internal class SimpleBackTrackingInArrays
    {
        public static void ChangeArray(int[] arr, int i, int val)
        {
            //base case
            if (i == arr.Length)
            {
                Console.WriteLine(string.Join(' ', arr));
            }

            arr[i] = val;
            ChangeArray(arr, i + 1, val + 1);
            arr[i] = arr[i] - 2;
        }
    }
}
