using System;

namespace SaveThePrisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int prisonersCount = int.Parse(Console.ReadLine());
            int sweetsCount = int.Parse(Console.ReadLine());
            int startingPosition = int.Parse(Console.ReadLine());

            var result = saveThePrisoner(prisonersCount, sweetsCount, startingPosition);
            Console.WriteLine(result);
        }

        static int saveThePrisoner(int n, int m, int s)
        {
            return ((s - 1 + m - 1) % n) + 1;
        }
    }
}
