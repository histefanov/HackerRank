using System;
using System.Linq;

namespace Ratios
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            double positivesRatio = arr.Where(x => x > 0).ToArray().Length * 1.0 / n;
            double negativesRatio = arr.Where(x => x < 0).ToArray().Length * 1.0 / n;
            double zerosRatio = 1 - (positivesRatio + negativesRatio);

            Console.WriteLine($"{positivesRatio:F6}\n{negativesRatio:F6}\n{zerosRatio:F6}");
        }
    }
}
