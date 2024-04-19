namespace DSAndAlgoConcepts.BackTracking
{
    internal class KnightsTourProblem
    {
        //static void Main(string[] args)
        //{
        //    int N = 8;
        //    var arr = new int[N, N];


        //    KnightsTour(arr, 0, 0);

        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr.GetLength(1); j++)
        //        {
        //            Console.Write(arr[i, j] + "    ");
        //        }
        //        Console.WriteLine();
        //    }

        //    if (counter == arr.Length)
        //    {
        //        Console.WriteLine("TRUE");
        //    }
        //    else
        //    {
        //        Console.WriteLine("FALSE");
        //    }

        //}

        static int counter = 0;
        static void KnightsTour(int[,] arr, int i, int j)
        {
            if (i < 0 || j < 0 || i >= arr.GetLength(0) || j >= arr.GetLength(1) || arr[i, j] > 0 || (i == 0 && j == 0 && counter > 0))
                return;

            arr[i, j] = counter++;

            KnightsTour(arr, i + 2, j + 1);
            KnightsTour(arr, i + 2, j - 1);
            KnightsTour(arr, i + 1, j + 2);
            KnightsTour(arr, i + 1, j - 2);
            KnightsTour(arr, i - 2, j + 1);
            KnightsTour(arr, i - 2, j - 1);
            KnightsTour(arr, i - 1, j + 2);
            KnightsTour(arr, i - 1, j - 2);
        }
    }
}
