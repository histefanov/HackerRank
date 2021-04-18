using System;
using System.Linq;

namespace SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matchingPairs = GetMatchingPairs(n, arr);
            Console.WriteLine(matchingPairs);
        }

        private static object GetMatchingPairs(int n, int[] arr)
        {
            if (n == 1)
            {
                return 0;
            }

            var orderedArr = arr.OrderBy(x => x).ToArray();
            var matchCounter = 0;

            for (int i = 0; i < n - 1; i+=2)
            {
                if (orderedArr[i] == orderedArr[i + 1])
                {
                    matchCounter++;
                }
                else
                {
                    i--;
                }
            }

            return matchCounter;
        }
    }
}
