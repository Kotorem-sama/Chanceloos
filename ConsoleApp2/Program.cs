using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main()
        {
            int[][] jagged = new int[][]{
            new int[]{2, 3},
            new int[]{7, 8, 9},
            new int[]{4}
            };
            string s = Method1D(jagged[1], 1);
            s = Method2D(jagged, 0, 0);
            Console.WriteLine(s);
        }

        public static string Method1D(int[] arr, int i)
        {
            if (i >= arr.Length)
            {
                return "";
            }
            return arr[i] + Method1D(arr, i + 1);
        }

        public static string Method2D(int[][] arr, int i, int j)
        {
            if (i >= arr.Length)
            {
                return "";
            }
            if (j < arr[i].Length)
            {
                return arr[i][j] + Method2D(arr, i, j + 1);
            }
            else
            {
                return "\n" + Method2D(arr, i + 1, 0);
            }
        }
    }
}
