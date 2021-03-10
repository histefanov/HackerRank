using System;
using System.Linq;

namespace BeautifulDays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lo = int.Parse(Console.ReadLine());
            int hi = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int beautifulDays = 0;

            for (int i = lo; i <= hi; i++)
            {
                var reversed = int.Parse(i.ToString().Reverse().ToString());
                
                if ((i - reversed) % k == 0)
                {
                    beautifulDays++;
                }
            }

            Console.WriteLine(beautifulDays);
        }
    }
}
