namespace _2DiagonalDifference
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];

            int[,] matrix = new int[rows, rows];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] data = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            long diagonalSumPrimary = 0;
            long diagonalSumSecondary = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        diagonalSumPrimary += matrix[i, j];
                    }
                    if (i == (rows - 1) - j)
                    {
                        diagonalSumSecondary += matrix[i, j];
                    }

                }
            }

            Console.WriteLine(Math.Abs(diagonalSumPrimary - diagonalSumSecondary));
        }



        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
