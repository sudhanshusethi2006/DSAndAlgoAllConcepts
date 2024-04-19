using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.LeetCodeQuestions.BackTracking
{
    class Solution
    {
        // static void Main(string[] args)
        //{

        //    var sudokuBoard = new char[][]
        //    {
        //        new char[] {'5','3','.','.','7','.','.','.','.'},
        //        new char[] {'6','.','.','1','9','5','.','.','.'},
        //        new char[] {'.','9','8','.','.','.','.','6','.'},
        //        new char[] {'8','.','.','.','6','.','.','.','3'},
        //        new char[] {'4','.','.','8','.','3','.','.','1'},
        //        new char[] {'7','.','.','.','2','.','.','.','6'},
        //        new char[] {'.','6','.','.','.','.','2','8','.'},
        //        new char[] {'.','.','.','4','1','9','.','.','5'},
        //        new char[] {'.','.','.','.','8','.','.','7','9'},
        //    };

        //    var sudoku = SudokuSolver(sudokuBoard, 0, 0);
        //    Console.WriteLine(sudoku);
        //    if (sudoku)
        //    {
        //        PrintSudoKu(sudokuBoard);
        //    }
        //}
        //public void SolveSudoku(char[][] board)
        //{
        //    SudokuSolver(board, 0, 0);
        //}

        static bool SudokuSolver(char[][] board, int row, int col)
        {
            if (row == 9 && col == 0)
                return true;

            int nextRow = row;
            int nextCol = col + 1;
            if (col + 1 == 9)
            {
                nextRow = row + 1;
                nextCol = 0;
            }

            if (board[row][col] != '.')
                return SudokuSolver(board, nextRow, nextCol);

            for (int digit = 1; digit <= 9; digit++)
            {
                if (IsSafe(board, row, col, digit))
                {
                    board[row][col] = char.Parse(digit.ToString());
                    if (SudokuSolver(board, nextRow, nextCol))
                        return true;
                    board[row][col] = '.';
                }
            }
            return false;
        }

        static bool IsSafe(char[][] board, int row, int col, int digit)
        {
            //horizontal  check

            for (int i = 0; i < 9; i++)
            {
                if (board[row][i] == char.Parse(digit.ToString()))
                    return false;
            }

            // vertical check

            for (int i = 0; i < 9; i++)
            {
                if (board[i][col] == char.Parse(digit.ToString()))
                    return false;
            }

            // check in the grid

            int startRow = (row / 3) * 3;
            int startCol = (col / 3) * 3;

            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (board[i][j] == char.Parse(digit.ToString()))
                    {
                        return false;
                    }
                }
            }

            return true;
        }


        private static void PrintSudoKu(char[][] sudokuBoard)
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
}
