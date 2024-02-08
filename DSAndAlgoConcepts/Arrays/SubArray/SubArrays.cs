namespace DSAndAlgoConcepts.Arrays.SubArray
{
    internal class SubArrays
    {


        static void PrintSubArrays(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i; j < arr.Length; j++)
                {
                    Console.Write("[");
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(arr[k] + (k == j ? "" : ","));
                    }
                    Console.Write("]");
                }
            }
        }

        static void PrintSubArraysSumWithMInMAxSum(int[] arr)
        {
            int maxSum = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i; j < arr.Length; j++)
                {
                    Console.Write("[");
                    int sum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        sum += arr[k];
                        Console.Write(arr[k] + (k == j ? "" : ","));
                    }
                    Console.Write("]");
                    Console.Write("\t" + sum + "\n");

                    maxSum = Math.Max(maxSum, sum);
                }
            }

            Console.WriteLine($"Max Sum is: {maxSum}");
        }
    }
}
