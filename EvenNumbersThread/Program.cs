using System;
using System.Threading;

namespace EvenNumbersThread
{
    class Program
    {
        static void Main(string[] args)
        {
            int lo = int.Parse(Console.ReadLine());
            int hi = int.Parse(Console.ReadLine());

            var thread = new Thread(() =>
            {
                PrintEvenNumbersInRange(lo, hi);
            });

            thread.Start();
            thread.Join();

            Console.WriteLine("Thread finished work");
        }

        private static void PrintEvenNumbersInRange(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                }
            }
        }
    }
}
