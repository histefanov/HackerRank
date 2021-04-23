using System;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int result = PageCount(n, p);

            Console.WriteLine(result);
        }

        static int PageCount(int n, int p)
        {
            int pageTurnsFromFront = p / 2;
            int pageTurnsFromBack = n / 2 - p / 2;

            return Math.Min(pageTurnsFromFront, pageTurnsFromBack);
        }
    }
}
