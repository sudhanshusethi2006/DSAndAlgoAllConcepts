namespace DSAndAlgoConcepts.BackTracking
{
    internal class Sudoku
    {
        //static void Main(string[] args)
        //{
        //    var sudokuBoard = new int[][]
        // {
        //        new int[] {5,3,0,0,7,0,0,0,0},
        //        new int[] {6,0,0,1,9,5,0,0,0},
        //        new int[] {0,9,8,0,0,0,0,6,0},
        //        new int[] {8,0,0,0,6,0,0,0,3},
        //        new int[] {4,0,0,8,0,3,0,0,1},
        //        new int[] {7,0,0,0,2,0,0,0,6},
        //        new int[] {0,6,0,0,0,0,2,8,0},
        //        new int[] {0,0,0,4,1,9,0,0,5},
        //        new int[] {0,0,0,0,8,0,0,7,9},
        // };
        //    var sudokuBoard2 = new int[][]
        //    {
        //        new int[] {0,0,8,0,0,0,0,0,0},
        //        new int[] {4,9,0,1,5,7,0,0,2},
        //        new int[] {0,0,3,0,0,4,1,9,0},
        //        new int[] {1,8,5,0,6,0,0,2,0},
        //        new int[] {0,0,0,0,2,0,0,6,0},
        //        new int[] {9,6,0,4,0,5,3,0,0},
        //        new int[] {0,3,0,0,7,2,0,0,4},
        //        new int[] {0,4,9,0,3,0,0,5,7},
        //        new int[] {8,2,7,0,0,9,0,1,3},
        //    };

        //    Thread t1 = new Thread(x =>
        //    {
        //        var sudoku = SudokuSolver(sudokuBoard, 0, 0);
        //        if (sudoku)
        //        {
        //            PrintSudoKu(sudokuBoard);
        //        }
        //    });

        //    Thread t2 = new Thread(x =>
        //    {
        //        var sudoku = SudokuSolver(sudokuBoard2, 0, 0);
        //        if (sudoku)
        //        {
        //            PrintSudoKu(sudokuBoard);
        //        }
        //    });

        //    t1.Start();
        //    t2.Start();

        //}

        private static void PrintSudoKu(int[][] sudokuBoard)
        {
            lock (thisLock)
            {
                for (int i = 0; i < sudokuBoard.Length; i++)
                {
                    for (int j = 0; j < sudokuBoard.Length; j++)
                    {
                        Console.Write(sudokuBoard[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        private static Object thisLock = new Object();
        static bool SudokuSolver(int[][] sudokuBoard, int row, int col)
        {
            lock (thisLock)
            {


                if (row == 9 && col == 0)
                {
                    return true;
                }


                int nextRow = row;
                int nextCol = col + 1;

                if (col + 1 == 9)
                {
                    nextRow = row + 1;
                    nextCol = 0;
                }

                if (sudokuBoard[row][col] != 0)
                    return SudokuSolver(sudokuBoard, nextRow, nextCol);
                //
                for (int digit = 1; digit <= 9; digit++)
                {
                    if (IsSafe(sudokuBoard, row, col, digit))
                    {
                        // Console.WriteLine($"---------------ADD--------------[{row},{col}]={digit}");
                        sudokuBoard[row][col] = digit;
                        if (SudokuSolver(sudokuBoard, nextRow, nextCol))
                        {
                            //     Console.WriteLine($"------Final-----[{row},{col}]={digit}");
                            return true;
                        }
                        //  Console.WriteLine($"-----------------UNDO-------------[{row},{col}]={digit}");
                        sudokuBoard[row][col] = 0;
                    }
                }
                return false;
            }
        }

        private static bool IsSafe(int[][] sudokuBoard, int row, int col, int digit)
        {
            // check for row
            for (int i = 0; i <= 8; i++)
            {
                if (sudokuBoard[i][col] == digit)
                    return false;
            }

            // check for column
            for (int i = 0; i <= 8; i++)
            {
                if (sudokuBoard[row][i] == digit)
                    return false;
            }

            //condition grid
            // starting row formula= (row/3) * 3
            // starting column formula= (col/3) * 3
            int startRow = (row / 3) * 3;
            int startCol = (col / 3) * 3;

            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (sudokuBoard[i][j] == digit)
                        return false;
                }
            }


            return true;
        }
    }
}
