using System;
using System.Linq;

namespace BetweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int result = GetTotalX(arr1, arr2);
            Console.WriteLine(result);
        }

        private static int GetTotalX(int[] a, int[] b)
        {
            var totalX = 0;

            for (int i = a.Max(); i <= b.Max(); i++)
            {
                bool flag = false;

                foreach (var num in a)
                {
                    if (i % num != 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag) continue;

                foreach (var num in b)
                {
                    if (num % i != 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag) continue;

                totalX++;
            }

            return totalX;
        }
    }
}
