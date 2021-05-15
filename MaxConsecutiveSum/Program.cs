using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxConsecutiveSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxSum = MaxSubarraySum(arr);
            Console.WriteLine(maxSum);
        }

        private static int MaxSubarraySum(int[] a)
        {
            var currentSum = a[0];
            var maxSum = currentSum;

            for (int i = 1; i < a.Length; i++)
            {
                currentSum = Math.Max(a[i] + currentSum, a[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}
