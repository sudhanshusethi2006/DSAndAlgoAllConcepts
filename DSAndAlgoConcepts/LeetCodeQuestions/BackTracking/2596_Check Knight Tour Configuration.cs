namespace DSAndAlgoConcepts.LeetCodeQuestions.BackTracking
{

    class Solution2
    {
        // int counter = 0;
        public bool CheckValidGrid(int[][] grid)
        {
            int i = 0;
            int j = 0;
            int N = grid.Length * grid.Length;
            for (int k = 0; k < N - 1; k++)
            {
                var nextPosistion = GetNextPosition(grid, i, j, k);
                if (nextPosistion[0] == -1 && nextPosistion[1] == -1)
                    return false;
                i = nextPosistion[0];
                j = nextPosistion[1];
            }
            //   if (counter != N)
            //     return false;
            return true;
        }

        public int[] GetNextPosition(int[][] grid, int i, int j, int Cell)
        {
            if (grid[i][j] != Cell) return new int[] { -1, -1 };
            if (i + 2 >= 0 && j + 1 >= 0 && i + 2 < grid.GetLength(0) && j + 1 < grid.GetLength(0) && grid[i + 2][j + 1] == Cell + 1)
            {
                //counter++;  
                return new int[] { i + 2, j + 1 };
            }
            if (i + 2 >= 0 && j - 1 >= 0 && i + 2 < grid.GetLength(0) && j - 1 < grid.GetLength(0) && grid[i + 2][j - 1] == Cell + 1)
            {
                // counter++;
                return new int[] { i + 2, j - 1 };
            }
            if (i + 1 >= 0 && j + 2 >= 0 && i + 1 < grid.GetLength(0) && j + 2 < grid.GetLength(0) && grid[i + 1][j + 2] == Cell + 1)
            {
                // counter++;
                return new int[] { i + 1, j + 2 };
            }
            if (i + 1 >= 0 && j - 2 >= 0 && i + 1 < grid.GetLength(0) && j - 2 < grid.GetLength(0) && grid[i + 1][j - 2] == Cell + 1)
            {
                //counter++;
                return new int[] { i + 1, j - 2 };
            }
            if (i - 2 >= 0 && j + 1 >= 0 && i - 2 < grid.GetLength(0) && j + 1 < grid.GetLength(0) && grid[i - 2][j + 1] == Cell + 1)
            {
                // counter++;
                return new int[] { i - 2, j + 1 };
            }
            if (i - 2 >= 0 && j - 1 >= 0 && i - 2 < grid.GetLength(0) && j - 1 < grid.GetLength(0) && grid[i - 2][j - 1] == Cell + 1)
            {
                //  counter++;
                return new int[] { i - 2, j - 1 };
            }
            if (i - 1 >= 0 && j + 2 >= 0 && i - 1 < grid.GetLength(0) && j + 2 < grid.GetLength(0) && grid[i - 1][j + 2] == Cell + 1)
            {
                //counter++;
                return new int[] { i - 1, j + 2 };
            }
            if (i - 1 >= 0 && j - 2 >= 0 && i - 1 < grid.GetLength(0) && j - 2 < grid.GetLength(0) && grid[i - 1][j - 2] == Cell + 1)
            {
                //   counter++;
                return new int[] { i - 1, j - 2 };
            }
            else
                return new int[] { -1, -1 };

        }
    }
    internal class _2596_Check_Knight_Tour_Configuration
    {
        //static void Main(string[] args)
        //{

        //    var grid3 = new int[,] { { 0, 11, 16, 5, 20 }, { 17, 4, 19, 10, 15 }, { 12, 1, 8, 21, 6 }, { 3, 18, 23, 14, 9 }, { 24, 13, 2, 7, 22 } };
        //    var grid = new int[][] { new int[] { 0, 11, 16, 5, 20 }, new int[] { 17, 4, 19, 10, 15 }, new int[] { 12, 1, 8, 21, 6 }, new int[] { 3, 18, 23, 14, 9 }, new int[] { 24, 13, 2, 7, 22 } };
        //    var grid2 = new int[][] { new int[] { 8, 3, 6 }, new int[] { 5, 0, 1 }, new int[] { 2, 7, 4 } };

        //    Solution solution = new Solution();
        //    solution.CheckValidGrid(grid);

        //    var isValid = CheckValidGrid(grid3);
        //}

        static int counter = 0;
        public static bool CheckValidGrid(int[,] grid)
        {

            int i = 0;
            int j = 0;

            for (int k = 0; k < grid.Length - 1; k++)
            {
                var nextPosistion = GetNextPosition(grid, i, j, k);
                if (nextPosistion[0] == -1 && nextPosistion[1] == -1)
                    return false;
                i = nextPosistion[0];
                j = nextPosistion[1];
            }
            if (counter != grid.Length)
                return false;


            return true;

        }

        public static int[] GetNextPosition(int[,] grid, int i, int j, int Cell)
        {
            if (i + 2 >= 0 && j + 1 >= 0 && i + 2 < grid.GetLength(0) && j + 1 < grid.GetLength(0) && grid[i + 2, j + 1] == Cell + 1)
            {
                counter++;
                return new int[] { i + 2, j + 1 };
            }
            else if (i + 2 >= 0 && j - 1 >= 0 && i + 2 < grid.GetLength(0) && j - 1 < grid.GetLength(0) && grid[i + 2, j - 1] == Cell + 1)
            {
                counter++;
                return new int[] { i + 2, j - 1 };
            }
            else if (i + 1 >= 0 && j + 2 >= 0 && i + 1 < grid.GetLength(0) && j + 2 < grid.GetLength(0) && grid[i + 1, j + 2] == Cell + 1)
            {
                counter++;
                return new int[] { i + 1, j + 2 };
            }
            else if (i + 1 >= 0 && j - 2 >= 0 && i + 1 < grid.GetLength(0) && j - 2 < grid.GetLength(0) && grid[i + 1, j - 2] == Cell + 1)
            {
                counter++;
                return new int[] { i + 1, j - 2 };
            }
            else if (i - 2 >= 0 && j + 1 >= 0 && i - 2 < grid.GetLength(0) && j + 1 < grid.GetLength(0) && grid[i - 2, j + 1] == Cell + 1)
            {
                counter++;
                return new int[] { i - 2, j + 1 };
            }
            else if (i - 2 >= 0 && j - 1 >= 0 && i - 2 < grid.GetLength(0) && j - 1 < grid.GetLength(0) && grid[i - 2, j - 1] == Cell + 1)
            {
                return new int[] { i - 2, j - 1 };
            }
            else if (i - 1 >= 0 && j + 2 >= 0 && i - 1 < grid.GetLength(0) && j + 2 < grid.GetLength(0) && grid[i - 1, j + 2] == Cell + 1)
            {
                counter++;
                return new int[] { i - 1, j + 2 };
            }
            else if (i - 1 >= 0 && j - 2 >= 0 && i - 1 < grid.GetLength(0) && j - 2 < grid.GetLength(0) && grid[i - 1, j - 2] == Cell + 1)
            {
                counter++;
                return new int[] { i - 1, j - 2 };
            }
            else
                return new int[] { -1, -1 };

        }




    }
}
