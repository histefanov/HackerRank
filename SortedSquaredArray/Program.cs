using System;
using System.Linq;

namespace SortedSquaredArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var result = sortedSquaredArray(arr);
            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] sortedSquaredArray(int[] a)
        {
            int[] result = new int[a.Length];
            int i = result.Length - 1;
            int n = 0;
            int p = a.Length - 1; 

            while (i >= 0)
            {
                int left = Math.Abs(a[n]);
                int right = a[p];

                if (left > right)
                {
                    result[i--] = left * left;
                    n++;
                }
                else
                {
                    result[i--] = right * right;
                    p--;
                }
            }

            return result;
        }
    }
}
