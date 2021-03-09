using System;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());
            int height = 1;

            for (int i = 0; i < cycles; i++)
            {
                if (i % 2 == 0)
                {
                    height *= 2;
                }
                else
                {
                    height++;
                }
            }

            Console.WriteLine(height);
        }
    }
}
