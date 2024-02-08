namespace DSAndAlgoConcepts.Arrays.SubArray
{
    internal class KadanesAlgorithmForMaxSubArraySum
    {

        //static void Main(string[] args)
        //{
        //    int[] arr = { -2, -3, 4, -1, -2, 1, 5, -3 };

        //    KadaneAlgorithm(arr);

        //}

        static void KadaneAlgorithm(int[] arr)
        {
            // this algorithm does not work if all numbers in the array are negative
            // According to Kadane's Algorithm, maintain 2 pointers ( Current sum and max Sum) . 

            int currentSum = 0;
            int MaxSum = 0;

            // Now update 2 pointers , if the current sum <0. then Current sum=0. Maintain Max sum

            var anyPositive = arr.Where(x => x > 0).Any();
            if (!anyPositive)
            {
                Console.Write("max sub array sum is  :" + arr.Max());
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] + currentSum < 0)
                    currentSum = 0;
                else
                    currentSum += arr[i];
                Console.WriteLine(currentSum);

                MaxSum = Math.Max(MaxSum, currentSum);
            }
            Console.Write("max sub array sum is  :" + MaxSum);



        }

    }
}
