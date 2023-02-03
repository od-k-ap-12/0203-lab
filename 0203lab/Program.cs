using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0203lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1

            int[][] arr = new int[5][];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[r.Next(1, 10)];
            }
            int maxlength = arr[0].Length;
            int minlength = arr[0].Length;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = r.Next(1, 10);
                    Console.Write($"{arr[i][j]} ");
                }
                Console.WriteLine();
                Console.WriteLine(arr[i].Length);

                if (arr[i].Length > maxlength)
                {
                    maxlength = i;
                }
                if (arr[i].Length < minlength)
                {
                    minlength = i;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"max:{maxlength}");
            Console.WriteLine($"min:{minlength}");

            (arr[maxlength], arr[minlength]) = (arr[minlength], arr[maxlength]);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]} ");
                }
                Console.WriteLine();
                Console.WriteLine();

            }

            #endregion


            #region 2
            int a = 6;
            int[][] arr2 = new int[4][];
            for (int i = 0; i < arr2.Length; i++)
            {
                if (i == arr2.Length - 1)
                {
                    arr2[i] = new int[6 - i - 1];
                }
                else
                {
                    arr2[i] = new int[6 - i];
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.Write($"{arr2[i][j]} ");
                }
                Console.WriteLine();
                Console.WriteLine();

            }
            #endregion
        }
    }
}
