using System;
using System.Linq;

namespace _3DSurfaceArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardDimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(boardDimensions[0]);
            int cols = int.Parse(boardDimensions[1]);

            int[][] board = ReadMatrix(rows, cols);
            int toyPrice = SurfaceArea(board);

            Console.WriteLine(toyPrice);
        }

        private static int[][] ReadMatrix(int rows, int cols)
        {
            int[][] board = new int[rows][];

            for (int r = 0; r < rows; r++)
            {
                int[] currCol = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                board[r] = new int[cols];

                for (int c = 0; c < cols; c++)
                {
                    board[r][c] = currCol[c];
                }
            }

            return board;
        }

        static int SurfaceArea(int[][] A)
        {
                int rows = A.Length;
                int cols = A[0].Length;

                int area = 2 * rows * cols;

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (r - 1 >= 0)
                        {
                            area += Math.Max(0, A[r][c] - A[r - 1][c]);
                        }
                        else
                        {
                            area += A[r][c];
                        }

                        if (r + 1 < rows)
                        {
                            area += Math.Max(0, A[r][c] - A[r + 1][c]);
                        }
                        else
                        {
                            area += A[r][c];
                        }

                        if (c - 1 >= 0)
                        {
                            area += Math.Max(0, A[r][c] - A[r][c - 1]);
                        }
                        else
                        {
                            area += A[r][c];
                        }

                        if (c + 1 < cols)
                        {
                            area += Math.Max(0, A[r][c] - A[r][c + 1]);
                        }
                        else
                        {
                            area += A[r][c];
                        }
                    }
                }

                return area;
        }
    }
}
