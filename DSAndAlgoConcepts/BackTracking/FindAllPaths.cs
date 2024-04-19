namespace DSAndAlgoConcepts.BackTracking
{
    internal class FindAllPathsAlgo
    {
        //static void Main(string[] args)
        //{
        //    int[,] matrix = { { 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 1, 1, 1, 1 }, { 0, 0, 1, 0, 0 }, { 1, 1, 1, 1, 1 } };
        //    int[][] matrix2 = new int[5][];
        //    matrix2[0] = new int[] { 1, 1, 1, 1, 1 };
        //    matrix2[1] = new int[] { 1, 0, 1, 0, 1 };
        //    matrix2[2] = new int[] { 1, 1, 1, 1, 1 };
        //    matrix2[3] = new int[] { 0, 0, 1, 0, 0 };
        //    matrix2[4] = new int[] { 1, 1, 1, 1, 1 };
        //    bool[][] visited = new bool[matrix2.GetLength(0)][];

        //    for (int i = 0; i < matrix2.GetLength(0); i++)
        //    {
        //        visited[i] = new bool[matrix2.GetLength(0)];
        //    }
        //    FindAllPaths(0, 0, matrix, new bool[matrix.GetLength(0), matrix.GetLength(1)], "");
        //    FindAllPaths3(0, 0, matrix2, visited, "");
        //}


        public static void FindAllPaths(int i, int j, int[,] arr, bool[,] Visited, string pathSoFar)
        {
            if (i < 0 || j < 0 || i >= arr.GetLength(0) || j >= arr.GetLength(1)) return;

            if (arr[i, j] == 0 || Visited[i, j]) return;

            if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
                Console.WriteLine("Reached Destination" + pathSoFar);

            Visited[i, j] = true;

            FindAllPaths(i, j - 1, arr, Visited, pathSoFar + "U");
            FindAllPaths(i, j + 1, arr, Visited, pathSoFar + "D");
            FindAllPaths(i - 1, j, arr, Visited, pathSoFar + "L");
            FindAllPaths(i + 1, j, arr, Visited, pathSoFar + "R");
            Visited[i, j] = false;


        }

        public static void FindAllPaths3(int i, int j, int[][] arr, bool[][] Visited, string pathSoFar)
        {
            if (i < 0 || j < 0 || i >= arr[0].Length || j >= arr[0].Length) return;

            if (arr[i][j] == 0 || Visited[i][j]) return;

            if (i == arr[0].Length - 1 && j == arr[0].Length - 1)
                Console.WriteLine("Reached Destination" + pathSoFar);

            Visited[i][j] = true;

            FindAllPaths3(i, j - 1, arr, Visited, pathSoFar + "U");
            FindAllPaths3(i, j + 1, arr, Visited, pathSoFar + "D");
            FindAllPaths3(i - 1, j, arr, Visited, pathSoFar + "L");
            FindAllPaths3(i + 1, j, arr, Visited, pathSoFar + "R");
            Visited[i][j] = false;


        }
    }
}
