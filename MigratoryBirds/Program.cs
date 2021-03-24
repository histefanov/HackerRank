using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            var birdSightings = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var result = MigratoryBirds(birdSightings);
            Console.WriteLine(result);
        }

        static int MigratoryBirds(List<int> birdSightings)
        {
            var occurences = new Dictionary<int, int>();

            foreach (var sighting in birdSightings.OrderBy(x => x))
            {
                if (!occurences.ContainsKey(sighting))
                {
                    occurences.Add(sighting, 0);
                }
                occurences[sighting]++;
            }

            var highestCount = occurences
                .OrderByDescending(x => x.Value)
                .First().Key;

            return highestCount;
        }
    }
}
