using System;
using System.Linq;

namespace SumOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] b = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int v = int.Parse(Console.ReadLine());

            bool result = SumOfTwo(a, b, v);
            Console.WriteLine(result);
        }

        private static bool SumOfTwo(int[] arr1, int[] arr2, int v)
        {
            if (arr1.Length == 0 || arr2.Length == 0)
            {
                return false;
            }

            int[] a = arr1.OrderBy(x => x).ToArray();
            int[] b = arr2.OrderByDescending(x => x).ToArray();           
            
            int i = 0;
            int j = 0;
            int s = 0;

            while (i < a.Length && j < b.Length)
            {
                s = a[i] + b[j];

                if (s < v)
                {
                    i++;
                }
                else if (s > v)
                {
                    j++;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
