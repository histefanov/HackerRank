using System;
using System.Collections.Generic;
using System.Linq;

namespace AscendingBinarySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var sortedElements = Rearrange(elements);

            Console.WriteLine(string.Join(", ", sortedElements));
        }

        public static List<int> Rearrange(List<int> elements)
        {
            elements = elements
                .OrderBy(n => Convert.ToString(n, 2), new CustomComparer())
                .ThenBy(n => n)
                .ToList();

            return elements;
        }
    }  
}
