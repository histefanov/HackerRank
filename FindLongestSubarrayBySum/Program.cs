using System;
using System.Collections.Generic;
using System.Linq;

namespace FindLongestSubarrayBySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var sum = int.Parse(Console.ReadLine());

            int[] subarrBoundaries = FindLongestSubarrayBySum(arr, sum);

            if (subarrBoundaries[1] != 0)
            {
                Console.WriteLine(string.Join(", ", subarrBoundaries));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        private static int[] FindLongestSubarrayBySum(int[] arr, int sum)
        {
            var boundaries = new int[2];
            var currentSum = arr[0] + arr[1];

            for (int i = 0, j = 1; i < arr.Length && j < arr.Length;)
            {
                if (currentSum < sum)
                {
                    if (j < arr.Length - 1)
                    {
                        currentSum += arr[++j];
                    }
                    else
                    {
                        break;
                    }
                }
                else if (currentSum > sum)
                {
                    currentSum -= arr[i++];
                }
                else
                {
                    if (j - i > boundaries[1] - boundaries[0])
                    {
                        boundaries[0] = i + 1;
                        boundaries[1] = j + 1;
                    }

                    if (j < arr.Length - 1)
                    {
                        currentSum += arr[++j];
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return boundaries;
        }
    }
}
