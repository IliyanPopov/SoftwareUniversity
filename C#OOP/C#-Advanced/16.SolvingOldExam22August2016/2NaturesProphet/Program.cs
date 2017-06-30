namespace _2NaturesProphet
{
    using System;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new char[] {' '})
                .Select(long.Parse)
                .ToArray();

            long rowsCount = dimentions[0];
            long colsCount = dimentions[1];

            long[,] matrix = new long[rowsCount, colsCount];

            string input = Console.ReadLine();

            while (input != "Bloom Bloom Plow")
            {
                var data = input
                    .Split(new char[] {' '})
                    .Select(long.Parse)
                    .ToArray();

                long flowerRow = data[0];
                long flowerCol = data[1];

                BloomFlowers(matrix, flowerRow, flowerCol);

                input = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(long[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.Append(Environment.NewLine);
            }

            Console.WriteLine(sb.ToString());
        }

        private static void BloomFlowers(long[,] matrix, long row, long col)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[row, j]++;
            }

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (j == row)
                {
                    continue;
                }
                matrix[j, col]++;
            }
        }
    }
}