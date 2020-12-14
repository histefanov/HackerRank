using System;

namespace NumberOfWaysToPartition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int numberOfWays = Partition(n, m);
            Console.WriteLine(numberOfWays);
        }

        private static int Partition(int n, int m)
        {
            if (n == 0)
            {
                return 1;
            }

            if (m == 0 || n < 0)
            {
                return 0;
            }

            return Partition(n - m, m) + Partition(n, m - 1);
        }
    }
}
