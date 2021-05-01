using System;

namespace NumberLineJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var v1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var v2 = int.Parse(Console.ReadLine());

            string result = IsSamePositionPossible(x1, v1, x2, v2);
            Console.WriteLine(result);
        }

        private static string IsSamePositionPossible(int x1, int v1, int x2, int v2)
        {
            var diff = Math.Abs(x1 - x2);
            var result = "NO";

            while (true)
            {
                x1 += v1;
                x2 += v2;

                if (Math.Abs(x1 - x2) >= diff)
                {
                    break;
                }
                else if (x1 == x2)
                {
                    result = "YES";
                    break;
                }
            }

            return result;
        }
    }
}
