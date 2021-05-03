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
        }

        private static int GetTotalX(int[] arr1, int[] arr2)
        {
            var totalX = 0;

            for (int i = 1; i <= arr2.Max(); i++)
            {

            }
        }
    }
}
