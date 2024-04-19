namespace DSAndAlgoConcepts.BackTracking
{
    internal class NQueens
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

        //    nQueens(Board, 0);
        //    Console.WriteLine("Total Ways  : " + count);

        //}

        static int count = 0;
        static void nQueens(char[][] Board, int row)
        {
            if (Board.Length == row)
            {
                count++;
                PrintBoard(Board);
                return;
            }

            for (int i = 0; i < Board.Length; i++)
            {
                if (isSafe(Board, row, i))
                {
                    Board[row][i] = 'Q';
                    nQueens(Board, row + 1);

                    Board[row][i] = '.';
                }
            }
        }

        public static void PrintBoard(char[][] Board)
        {
            Console.WriteLine(new string('-', Board.Length));
            for (int i = 0; i < Board.Length; i++)
            {
                for (int j = 0; j < Board.Length; j++)
                {
                    Console.Write(Board[i][j] + " ");

                }
                Console.WriteLine();
            }

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
