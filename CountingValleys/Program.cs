using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            string path = Console.ReadLine();

            int valleysCount = CountValleys(steps, path);
            Console.WriteLine(valleysCount);
        }

        public static int CountValleys(int steps, string path)
        {
            int level = 0;
            int valleysCount = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    if (++level == 0)
                    {
                        valleysCount++;
                    }
                }
                else
                {
                    level--;
                }
            }

            return valleysCount;
        }
    }
}
