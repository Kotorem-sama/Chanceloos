using System;

namespace ConsoleApp2
{
    class Program
    {
        public static string[] Push(string[] aras, string addd)
        {
            string[] newara = new string[aras.Length + 1];
            for (int i = 0; i < aras.Length; i++)
            {
                newara[i] = aras[i];
            }
            newara[aras.Length] = addd;
            return newara;
        }

        public static string Peek(string[] ara)
        {
            return ara[ara.Length - 1];
        }

        public static Tuple<string[], string> Pop(string[] aras)
        {
            string[] newara = new string[aras.Length - 1];
            for (int i = 0; i < aras.Length - 1; i++)
            {
                newara[i] = aras[i];
            }
            return Tuple.Create(newara, aras[aras.Length - 1]);
        }

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
    }
}
