using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstDuplicate = GetFirstDuplicate(array);
            Console.WriteLine(firstDuplicate);
        }

        private static int GetFirstDuplicateWithHashSet(int[] a)
        {
            var result = -1;
            var seen = new HashSet<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (seen.Contains(a[i]))
                {
                    result = a[i];
                    break;
                }

                seen.Add(a[i]);
            }

            return result;
        }

        private static int GetFirstDuplicate(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[Math.Abs(a[i] - 1)] < 0)
                {
                    return Math.Abs(a[i]);
                }
                else
                {
                    a[Math.Abs(a[i] - 1)] = -a[Math.Abs(a[i] - 1)];
                }
            }

            return -1;
        }
    }
}
