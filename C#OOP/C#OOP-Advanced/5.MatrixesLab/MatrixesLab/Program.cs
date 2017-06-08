namespace MatrixesLab
{
    using System;
    using System.Linq;

    class Program

    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] data = Console.ReadLine()
                    .Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = data[j];
                }
            }

            long sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}