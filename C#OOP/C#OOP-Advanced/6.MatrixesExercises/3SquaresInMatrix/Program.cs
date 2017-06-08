namespace _3SquaresInMatrix
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var matrixSizes = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);


            char[][] matrix = new char[Int32.Parse(matrixSizes[0])][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(Convert.ToChar)
                    .ToArray();
            }

            int counterOfEqual2By2SubMatrixes = 0;

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    //var v1 = matrix[row][col];
                    //var v2 = matrix[row + 1][col];
                    //var v3 = matrix[row][col + 1];
                    //var v4 = matrix[row + 1][col + 1];

                    if (matrix[row][col] == matrix[row + 1][col] &&
                        matrix[row][col] == matrix[row][col + 1] &&
                        matrix[row][col] == matrix[row + 1][col + 1])
                    {
                        counterOfEqual2By2SubMatrixes++;
                    }
                }
            }

            Console.WriteLine(counterOfEqual2By2SubMatrixes);
        }
    }
}