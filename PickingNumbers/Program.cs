using System;
using System.Collections.Generic;
using System.Linq;

namespace PickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var result = PickingNumbers(arr);
            Console.WriteLine(result);
        }

        public static int PickingNumbers(List<int> a)
        {
            var sortedArr = a.OrderBy(x => x).ToList();
            var total = 1;
            var initialElement = sortedArr[0];
            var totals = new List<int>();

            for (int i = 1; i < sortedArr.Count; i++)
            {
                if (sortedArr[i] - initialElement <= 1)
                {
                    total++;
                }
                else
                {
                    initialElement = sortedArr[i];
                    total = 1;
                }

                totals.Add(total);
            }

            return totals.Max();
        }
    }
}
