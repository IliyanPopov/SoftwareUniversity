namespace MaximumSumOf2x2Matrix
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var matrixSizes = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);


            int[][] matrix = new int[Int32.Parse(matrixSizes[0])][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var maxSquareRow = 0;
            var maxSquareCol = 0;
            var maxSum = int.MinValue;

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    var newSquareSum = matrix[row][col] +
                                       matrix[row + 1][col] +
                                       matrix[row][col + 1] +
                                       matrix[row + 1][col + 1];
                    //TODO: Check if sum is bigger
                    if (maxSum < newSquareSum)
                    {
                        maxSum = newSquareSum;
                        maxSquareRow = row;
                        maxSquareCol = col;
                    }
                }
            }

            Console.WriteLine(
                $"{matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol + 1]} {Environment.NewLine}" +
                $"{matrix[maxSquareRow + 1][maxSquareCol]} {matrix[maxSquareRow + 1][maxSquareCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}