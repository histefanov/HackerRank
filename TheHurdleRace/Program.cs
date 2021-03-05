using System;
using System.Linq;

namespace TheHurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var hurdles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var jumpingHeight = int.Parse(Console.ReadLine());

            var highestHurdle = hurdles.Max();
            var potionsRequired = highestHurdle - jumpingHeight;

            Console.WriteLine(potionsRequired > 0 ? potionsRequired : 0);
        }
    }
}
