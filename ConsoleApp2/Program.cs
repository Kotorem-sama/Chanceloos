using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main()
        {
            bool game6 = IsWinState(new char[][]{
            new char[]{'o', 'x', 'o', 'o'},
            new char[]{'o', 'x', 'x', 'o'},
            new char[]{'x', 'o', 'x', 'x'},
            new char[]{'x', 'o', 'x', 'x'},
            });
            Console.WriteLine(game6);
        }
        public static bool IsWinState(char[][] board)
        {
            //horizontal
            for (int i = 0; i < board.Length; i++)
            {
                char check = board[i][0];
                bool checker = true;
                if (board[i][0] == ' ')
                {
                    checker = false;
                }
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (check != board[i][j])
                    {
                        checker = false;
                        break;
                    }
                }
                if (checker)
                {
                    return true;
                }
            }

            //vertical
            for (int i = 0; i < board.Length; i++)
            {
                char check = board[0][i];
                bool checker = true;
                if (board[0][i] == ' ')
                {
                    checker = false;
                }
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (check != board[j][i])
                    {
                        checker = false;
                        break;
                    }
                }
                if (checker)
                {
                    return true;
                }
            }

            //diagonal right
            char check2 = board[0][0];
            bool checker2 = true;
            if (board[0][0] == ' ')
            {
                checker2 = false;
            }
            for (int j = 0; j < board[0].Length; j++)
            {
                if (check2 != board[j][j])
                {
                    checker2 = false;
                    break;
                }
            }
            if (checker2)
            {
                return true;
            }

            //diagonal left
            char check3 = board[board.Length - 1][0];
            bool checker3 = true;
            if (board[board.Length - 1][0] == ' ')
            {
                checker3 = false;
            }
            for (int j = 0; j < board[0].Length; j++)
            {
                if (check3 != board[board.Length - 1 - j][j])
                {
                    checker3 = false;
                    break;
                }
            }
            if (checker3)
            {
                return true;
            }
            return false;
        }
    }
}
