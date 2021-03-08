using System;
using System.Linq;

namespace DesignerPDFViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            var heights = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var word = Console.ReadLine();

            var largestLetterHeight = 0;

            for (int i = 0; i < word.Length; i++)
            {
                var currentLetter = word[i];
                var currentLetterHeight = heights[(int)currentLetter - 97];

                if (currentLetterHeight > largestLetterHeight)
                {
                    largestLetterHeight = currentLetterHeight;
                }
            }

            var selectionArea = word.Length * largestLetterHeight;
            Console.WriteLine(selectionArea);
        }
    }
}
