using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Hanoi(n, 1, 3);
        }

        private static void Hanoi(int n, int start, int end)
        {
            if (n == 1)
            {
                PrintMove(start, end);
                return;
            }

            int remainingRod = 6 - (start + end);
            Hanoi(n - 1, start, remainingRod);
            PrintMove(start, end);
            Hanoi(n - 1, remainingRod, end);
        }

        private static void PrintMove(int start, int end)
        {
            Console.WriteLine(start + "->" + end);
        }
    }
}
