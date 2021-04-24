using System;
using System.Linq;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = int.Parse(Console.ReadLine());
            int[] keyboards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] usbDrives = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var result = GetMoneySpent(keyboards, usbDrives, budget);
            Console.WriteLine(result);
        }

        static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var currentHighestPrice = -1;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    var combinationPrice = keyboards[i] + drives[j];

                    if (combinationPrice <= b && 
                        combinationPrice > currentHighestPrice)
                    {
                        currentHighestPrice = combinationPrice;
                    }
                }
            }

            return currentHighestPrice;
        }
    }
}
