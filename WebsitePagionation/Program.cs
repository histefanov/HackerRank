using System;
using System.Collections.Generic;
using System.Linq;

namespace WebsitePagionation
{
    class Program
    {
        static void Main(string[] args)
        {
            int itemSize = int.Parse(Console.ReadLine());
            int attributeCount = int.Parse(Console.ReadLine());

            List<List<string>> items = ReadMatrix(itemSize, attributeCount);

            int colToSort = int.Parse(Console.ReadLine());
            int sortOrder = int.Parse(Console.ReadLine());
            int itemsPerPage = int.Parse(Console.ReadLine());
            int pageNumber = int.Parse(Console.ReadLine());

            if (sortOrder == 0)
            {
                items = items.OrderBy(l => l[colToSort]).ToList();
            }
            else
            {
                items = items.OrderByDescending(l => l[colToSort]).ToList();
            }

            var res = FetchItemsToDisplay(items, colToSort, sortOrder, itemsPerPage, pageNumber);

            Console.WriteLine(string.Join(' ', res));
        }

        public static List<List<string>> ReadMatrix(int rows, int cols)
        {
            var matrix = new List<List<string>>();

            for (int r = 0; r < rows; r++)
            {
                List<string> line = Console.ReadLine().Split().ToList();
                matrix.Add(line);
            }

            return matrix;
        }

        public static void Print(string[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + "->");
                }
                Console.WriteLine();
            }
        }

        public static List<string> FetchItemsToDisplay(
            List<List<string>> items,
            int sortParameter,
            int sortOrder,
            int itemsPerPage,
            int pageNumber)
        {

            List<string> res = new List<string>();
            int startingItemIndex = (pageNumber - 1) * itemsPerPage;

            for (int i = startingItemIndex; i < startingItemIndex + itemsPerPage && i < items.Count; i++)
            {
                res.Add(items[i][0]);
            }
            return res;
        }
    }
}
