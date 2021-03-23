using System;
using System.Linq;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var records = breakingRecords(scores);
            Console.WriteLine(String.Join(", ", records));
        }

        static int[] breakingRecords(int[] scores)
        {
            int currentMin, currentMax, minRecords, maxRecords;

            currentMin = currentMax = scores[0];
            minRecords = maxRecords = 0;

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < currentMin)
                {
                    currentMin = scores[i];
                    minRecords++;
                }
                else if (scores[i] > currentMax)
                {
                    currentMax = scores[i];
                    maxRecords++;
                }
            }

            return new int[] { maxRecords, minRecords };
        }
    }
}
