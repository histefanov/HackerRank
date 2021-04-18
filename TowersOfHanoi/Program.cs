using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int start = 1;
            int end = 3;

            Hanoi(n, start, end);
        }

        private static void Hanoi(int n, int start, int end)
        {
            if (n == 1)
            {
                Console.WriteLine(start + " -> " + end);
                return;
            }

            int other = 6 - (start + end);
            Hanoi(n - 1, start, other);
            Console.WriteLine(start + " -> " + end);
            Hanoi(n - 1, other, end);
        }
    }
}
