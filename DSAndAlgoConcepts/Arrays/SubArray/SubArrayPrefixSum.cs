namespace DSAndAlgoConcepts.Arrays.SubArray
{
    internal class SubArrayPrefixSum
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { -2, -3, 4, -1, -2, 1, 5, -3 };
        //    CalculateSubarraySumAndMaxSum(arr);


        //}


        static void CalculateSubarraySumAndMaxSum(int[] arr)
        {
            var prefixArray = GetPrefixArray(arr);

            // calculate sum of each sub array using prefix array and max sum

            int maxSum = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    var sum = i == 0 ? prefixArray[j] : prefixArray[j] - prefixArray[i - 1];
                    Console.WriteLine(sum);
                    maxSum = Math.Max(maxSum, sum);
                }
            }
            Console.WriteLine($"Max sum is : {maxSum}");
        }

        static int[] GetPrefixArray(int[] arr)
        {
            if (arr.Any())
            {
                var prefixArray = new int[arr.Length];
                prefixArray[0] = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    prefixArray[i] = prefixArray[i - 1] + arr[i];
                }
                return prefixArray;
            }
            return arr;
        }
    }
}
