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
            while (m > 0)
            {
                s++;
                if (s == n)
                {
                    s = 1;
                }
                m--;
            }

            return s;
        }
    }
}
