using System;
using System.Threading.Tasks;

namespace AsynchronousDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEvenAndOddAsynchronously();
        }

        private static void PrintEvenAndOddAsynchronously()
        {
            var evenTask = Task.Run(() =>
            {
                for (int i = 0; i <= 100; i+=2)
                {
                    Console.WriteLine(i);
                }
            });

            var oddTask = Task.Run(() =>
            {
                for (int i = 1; i <= 99; i+=2)
                {
                    Console.WriteLine(i);
                }
            });

            Task.WaitAll(evenTask, oddTask);
        }
    }
}
