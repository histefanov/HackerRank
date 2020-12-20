using System;
using System.Linq;

namespace Mini_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var result = MinMaxSum(arr);
            Console.WriteLine(result);
        }

        private static string MinMaxSum(int[] arr)
        {
            arr = arr.OrderBy(x => x).ToArray();
            long minSum = 0;
            long maxSum = 0;

            foreach (var num in arr.Take(4))
            {
                minSum += num;
            }

            foreach (var num in arr.Skip(1))
            {
                maxSum += num;
            }

            return String.Format("{0} {1}", minSum, maxSum);
        }
    }
}
