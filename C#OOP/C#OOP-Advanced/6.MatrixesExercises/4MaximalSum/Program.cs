namespace _4MaximalSum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] data = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            // Find the maximal sum platform of size 3 x 3
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                              matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                              matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            // Print the result
            Console.WriteLine($"Sum = {bestSum}");
            Console.WriteLine(
                $"{matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]} {matrix[bestRow, bestCol + 2]}");
            Console.WriteLine(
                $"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]} {matrix[bestRow + 1, bestCol + 2]}");
            Console.WriteLine(
                $"{matrix[bestRow + 2, bestCol]} {matrix[bestRow + 2, bestCol + 1]} {matrix[bestRow + 2, bestCol + 2]}");
        }
    }
}