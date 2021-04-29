using System;
using System.Linq;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            int lb = int.Parse(Console.ReadLine());
            int rb = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());

            var apples = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var oranges = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            GetApplesAndOranges(lb, rb, a, o, apples, oranges);
        }

        private static void GetApplesAndOranges(int lb, int rb, int a, int o, int[] apples, int[] oranges)
        {
            var appleCount = 0;
            var orangeCount = 0;

            foreach (var apple in apples)
            {
                var location = a + apple;

                if (location >= lb && location <= rb)
                {
                    appleCount++;
                }
            }

            foreach (var orange in oranges)
            {
                var location = o + orange;

                if (location >= lb && location <= rb)
                {
                    orangeCount++;
                }
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }
}
