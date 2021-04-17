using System;
using System.Linq;

namespace CircularArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            int k = int.Parse(Console.ReadLine());

            var queries = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            var result = CircularArrayRotation(array, k, queries); 
            Console.WriteLine(string.Join(", ", result));
        }

        static int[] CircularArrayRotation(int[] a, int k, int[] queries)
        {
            for (int i = 0; i < k % a.Length; i++)
            {
                int[] newArray = new int[a.Length];
                newArray[0] = a[^1];

                for (int j = 1; j < newArray.Length; j++)
                {
                    newArray[j] = a[j - 1];
                }

                a = newArray;
            }

            int[] r = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                r[i] = a[queries[i]];
            }

            return r;
        }
    }
}
