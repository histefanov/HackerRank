using System;
using System.Collections.Generic;
using System.Linq;

namespace FormingAMagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> square = GetSquareInput(3);
            var minConvertionCost = FormMagicSquare(square);

            Console.WriteLine(minConvertionCost);
        }

        private static List<List<int>> GetSquareInput(int size)
        {
            var result = new List<List<int>>();

            for (int i = 0; i < size; i++)
            {
                var currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                result.Add(currentRow);
            }

            return result;
        }

        public static int FormMagicSquare(List<List<int>> s)
        {
            var pre = new List<int[,]>()
            {
                new int[,] { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } },
                new int[,] { { 6, 1, 8 }, { 7, 5, 3 }, { 2, 9, 4 } },
                new int[,] { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } },
                new int[,] { { 2, 9, 4 }, { 7, 5, 3 }, { 6, 1, 8 } },
                new int[,] { { 8, 3, 4 }, { 1, 5, 9 }, { 6, 7, 2 } },
                new int[,] { { 4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 } },
                new int[,] { { 6, 7, 2 }, { 1, 5, 9 }, { 8, 3, 4 } },
                new int[,] { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } }
            };

            var totals = new List<int>();

            for (int i = 0; i < pre.Count; i++)
            {
                var total = 0;

                for (int j = 0; j < s.Count; j++)
                {
                    for (int k = 0; k < s.Count; k++)
                    {
                        total += Math.Abs(s[j][k] - pre[i][j, k]);
                    }
                }

                totals.Add(total);
            }

            return totals.Min();
        }

        static List<int[,]> Generate3x3MagicSquares()
        {
            var result = new List<int[,]>();
            var preSquare = new int[,]
            {
                { 4, 3, 8 },
                { 9, 5, 1 },
                { 2, 7, 6 }
            };

            result.Add(preSquare);

            //TODO: Complete function

            return result;
        }
    }
}
