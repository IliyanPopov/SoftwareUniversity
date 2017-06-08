namespace _4PascalTriangle
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            var result = GetPascalTriangleImproved(rows);

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    Console.Write($"{result[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        public static BigInteger[][] GetPascalTriangleImproved(int rows)
        {
            BigInteger[][] result = new BigInteger[rows + 1][];
            for (int x = 0; x < rows; x++)
            {
                result[x] = new BigInteger[x + 1];
                result[x][0] = 1; // first element is ALWAYS 1

                for (int x1 = 1; x1 <= x; x1++)
                {
                    // last element is always 1 (just like the first)
                    if (x1 == x)
                    {
                        result[x][x] = 1;
                        continue;
                    }

                    // in all other cases, just add the 2 digits in the upper row
                    result[x][x1] = result[x - 1][x1 - 1] + result[x - 1][x1];
                }
            }
            return result;
        }
    }
}