using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Minesweeper
    {
        public static void MS()
        {
            int[][] board = new int[][] { new int[3] { 0, -1, 0 }, new int[3] { 0, 0, 0 }, new int[3] { -1, 0, 0 } };

            string before = Stringify(board);
            Console.WriteLine(before);
            PopulateMineCounts(board);
            string after = Stringify(board);
            Console.WriteLine(after);
        }

        public static string Stringify(int[][] board2)
        {
            string sty = "";
            for (int i = 0; i < board2.Length; i++)
            {
                for (int j = 0; j < board2[i].Length; j++)
                {
                    if (board2[i][j] == -1)
                    {
                        sty += "*";
                    }
                    else
                    {
                        sty += board2[i][j];
                    }
                }
                sty += "\n";
            }
            return sty;
        }

        public static string[] BombLocation(int[][] board4)
        {
            int bombcount = 0;
            for (int i = 0; i < board4.Length; i++)
            {
                for (int j = 0; j < board4[i].Length; j++)
                {
                    if (board4[i][j] == -1)
                    {
                        bombcount += 1;
                    }
                }
            }
            string[] sty = new string[bombcount];
            int index = 0;
            for (int i = 0; i < board4.Length; i++)
            {
                for (int j = 0; j < board4[i].Length; j++)
                {
                    if (board4[i][j] == -1)
                    {
                        sty[index] = $"{i}/{j}";
                        index++;
                    }
                }
            }
            return sty;
        }

        public static string[] Location(int i, int j)
        {
            string[] locat = new string[9];
            locat[0] = $"{i - 1}/{j - 1}";
            locat[1] = $"{i - 1}/{j}";
            locat[2] = $"{i - 1}/{j + 1}";
            locat[3] = $"{i}/{j - 1}";
            locat[4] = $"{i}/{j}";
            locat[5] = $"{i}/{j + 1}";
            locat[6] = $"{i + 1}/{j - 1}";
            locat[7] = $"{i + 1}/{j}";
            locat[8] = $"{i + 1}/{j + 1}";
            return locat;
        }

        public static void PopulateMineCounts(int[][] board3)
        {
            string[] Bombs = BombLocation(board3);
            for (int i = 0; i < board3.Length; i++)
            {
                for (int j = 0; j < board3[i].Length; j++)
                {
                    if (board3[i][j] != -1)
                    {
                        int bombcount = 0;
                        string[] locations = Location(i, j);
                        for (int k = 0; k < locations.Length; k++)
                        {
                            for (int l = 0; l < Bombs.Length; l++)
                            {
                                if (locations[k] == Bombs[l])
                                {
                                    bombcount += 1;
                                }
                            }
                        }
                        board3[i][j] = bombcount;
                    }
                }
            }
            return;
        }
    }
}
