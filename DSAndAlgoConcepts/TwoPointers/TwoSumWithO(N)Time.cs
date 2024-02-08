namespace DSAndAlgoConcepts.TwoPointers
{
    // mostly used with arrays, linked list and strings
    internal class Sample
    {
        //static void Main(string[] args)
        //{

        //    int[] arr = new int[] { 2, 3, 4 };
        //    var res = TwoSum(arr, 6);
        //}
        public static int[] TwoSum(int[] numbers, int target)
        {

            int p = 0;
            int q = numbers.Length - 1;
            while (p < q)
            {
                int sum = numbers[p] + numbers[q];
                if (sum == target) return new int[] { p + 1, q + 1 };
                if (sum > target)
                {
                    q--;
                }
                else p++;

            }
            return new int[] { };
        }
    }
}
