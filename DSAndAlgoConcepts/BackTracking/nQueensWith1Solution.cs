namespace DSAndAlgoConcepts.BackTracking
{
    class nQueensWith1Solution
    {
        //static void Main(string[] args)
        //{
        //    int n = 4;
        //    char[][] Board = new char[n][];

        //    for (int i = 0; i < n; i++)
        //    {
        //        Board[i] = new char[n];
        //        for (int j = 0; j < n; j++)
        //        {
        //            Board[i][j] = '.';
        //        }
        //    }

        //    var isSolutionPossible = nQueens(Board, 0);
        //    Console.WriteLine(isSolutionPossible);
        //    NQueens.PrintBoard(Board);
        //}

        static bool nQueens(char[][] Board, int row)
        {
            if (Board.Length == row)
            {
                return true;
            }

            for (int i = 0; i < Board.Length; i++)
            {
                if (isSafe(Board, row, i))
                {
                    Board[row][i] = 'Q';
                    if (nQueens(Board, row + 1))
                        return true;

                    Board[row][i] = '.';
                }
            }
            return false;
        }
        static bool isSafe(char[][] Board, int row, int col)
        {
            // vertical up
            // start from 1 row up
            for (int i = row - 1; i >= 0; i--)
            {
                if (Board[i][col] == 'Q')
                    return false;
            }

            // diagonal left up
            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (Board[i][j] == 'Q')
                    return false;
            }

            // diagonal right up
            for (int i = row - 1, j = col + 1; i >= 0 && j < Board.Length; i--, j++)
            {
                if (Board[i][j] == 'Q')
                    return false;
            }

            return true;
        }
    }
}
