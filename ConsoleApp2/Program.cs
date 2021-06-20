using System;

namespace ConsoleApp2
{
    class Program
    {
        public static bool AreSameSize(int[][] arr1, int[][] arr2)
        {
            int count1 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                count1 += arr1[i].Length;
            }
            count1 *= arr1.Length;

            int count2 = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                count2 += arr2[i].Length;
            }
            count2 *= arr2.Length;
            if (count1 == count2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int[][] AddArrays(int[][] arr1, int[][] arr2)
        {
            bool check = AreSameSize(arr1, arr2);
            if (check)
            {
                int[][] ret = new int[arr1.Length][];
                for (int i = 0; i < arr1.Length; i++)
                {
                    ret[i] = new int[arr1[i].Length];
                    for (int j = 0; j < arr1[i].Length; j++)
                    {
                        ret[i][j] = arr1[i][j] + arr2[i][j];
                    }
                }
                return ret;
            }
            return null;
        }
    }
}
