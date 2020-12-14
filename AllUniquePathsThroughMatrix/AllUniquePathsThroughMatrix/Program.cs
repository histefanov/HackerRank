using System;

namespace AllUniquePathsThroughMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            var matrix = GenerateMatrix(n, m);
            var numberOfUnqiuePaths = GeneratePath(matrix, 0, 0, "");
            Console.WriteLine($"Number of unique paths: {numberOfUnqiuePaths}");
        }

        private static int GeneratePath(int[,] matrix, int row, int col, string path)
        {
            var paths = 0;

            if (row == matrix.GetLength(0) - 1 && col == matrix.GetLength(1) - 1)
            {
                Console.WriteLine(path);
                return 1;
            }

            if (IsWithinBounds(matrix, row, col) && matrix[row, col] == 0)
            {
                matrix[row, col] = 1;
                paths += GeneratePath(matrix, row + 1, col, path + "D");
                paths += GeneratePath(matrix, row, col + 1, path + "R");
                matrix[row, col] = 0;
            }

            return paths;
        }

        private static bool IsWithinBounds(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }

        private static int[,] GenerateMatrix(int n, int m)
        {
            var matrix = new int[n, m];
            return matrix;
        }
    }
}
