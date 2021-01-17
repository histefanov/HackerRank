using System;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candles = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            candles = candles.OrderByDescending(x => x).ToArray();

            var result = 1;
            var idx = 0;
            bool areEqual = true;

            while (areEqual && idx + 1 < candles.Length)
            {
                if (candles[idx] == candles[idx + 1])
                {
                    result += 1;
                    idx += 1;
                }
                else
                {
                    areEqual = false;
                }
            }

            Console.WriteLine(result);
        }
    }
}
