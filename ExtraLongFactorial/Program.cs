using System;
using System.Numerics;

namespace ExtraLongFactorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = Fac(n);
            Console.WriteLine(result);
        }

        public static BigInteger Fac(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Fac(n - 1);
        }
    }
}
