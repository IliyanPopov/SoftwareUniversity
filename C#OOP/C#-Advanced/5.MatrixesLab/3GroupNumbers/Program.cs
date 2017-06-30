namespace _3GroupNumbers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] sizes = new int[3];
            foreach (var number in numbers)
            {
                int reminder = number % 3;
                if (reminder < 0)
                {
                    sizes[reminder * -1]++;
                }
                else
                {
                    sizes[reminder]++;
                }
            }

            int[][] matrix =
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]]
            };

            int[] offsets = new int[3];
            foreach (var number in numbers)
            {
                int reminder = number % 3;

                if (reminder < 0)
                {
                    int index = offsets[reminder * -1];
                    matrix[reminder * -1][index] = number;
                    offsets[reminder * -1]++;
                }
                else
                {
                    int index = offsets[reminder];
                    matrix[reminder][index] = number;
                    offsets[reminder]++;
                }
            }


            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}