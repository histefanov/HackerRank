using System;
using System.Linq;

namespace ProductExceptSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] result = ProductExceptSelfWithoutDivisionAndWithConstantSpaceComplexity(arr);
            Console.WriteLine(string.Join(", ", result));
        }

        private static int[] ProductExceptSelfWithDivision(int[] arr)
        {
            int[] result = new int[arr.Length];
            int product = arr.Aggregate(1, (a, b) => a * b);

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = product / arr[i];
            }

            return result;
        }

        private static int[] ProductExceptSelfWithoutDivision(int[] arr)
        {
            int n = arr.Length;
            
            int[] leftProducts = new int[n];
            int[] rightProducts = new int[n];
            int[] result = new int[n];

            leftProducts[0] = 1;
            rightProducts[n - 1] = 1;

            for (int i = 1; i < n; i++)
            {
                leftProducts[i] = arr[i - 1] * leftProducts[i - 1];
            }

            for (int i = n - 2; i >= 0; i--)
            {
                rightProducts[i] = arr[i + 1] * rightProducts[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                result[i] = leftProducts[i] * rightProducts[i];
            }

            return result;
        }

        private static int[] ProductExceptSelfWithoutDivisionAndWithConstantSpaceComplexity(int[] a)
        {
            int n = a.Length;
            int[] r = new int[n];

            r[0] = 1;

            for (int i = 1; i < n; i++)
            {
                r[i] = r[i - 1] * a[i - 1];
            }

            int rp = 1;

            for (int i = n - 1; i >= 0; i--)
            {
                r[i] *= rp;
                rp *= a[i];
            }

            return r;
        }
    }
}
