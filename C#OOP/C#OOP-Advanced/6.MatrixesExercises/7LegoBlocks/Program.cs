namespace _7LegoBlocks
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] jaggedArray1 = new long[rows][];
            long[][] jaggedArray2 = new long[rows][];

            for (int i = 0; i < jaggedArray1.Length; i++)
            {
                string[] inputNumbers = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                jaggedArray1[i] = new long[inputNumbers.Length];

                for (int j = 0; j < jaggedArray1[i].Length; j++)
                {
                    jaggedArray1[i][j] = int.Parse(inputNumbers[j]);
                }
            }

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                string[] inputNumbers = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                jaggedArray2[i] = new long[inputNumbers.Length];

                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    jaggedArray2[i][j] = int.Parse(inputNumbers[j]);
                }
            }

            //reverse second arr

            long[][] jaggedArray2Reversed = new long[rows][];

            for (int i = 0; i < jaggedArray2Reversed.Length; i++)
            {
                jaggedArray2Reversed[i] = jaggedArray2[i]
                    .Reverse()
                    .ToArray();
            }


            //combine 2 arrs
            long[][] jaggedArrayCombined = new long[rows][];

            for (int i = 0; i < jaggedArrayCombined.Length; i++)
            {
                jaggedArrayCombined[i] = jaggedArray1[i]
                    .Concat(jaggedArray2Reversed[i])
                    .ToArray();
            }

            //check if rows count match
            bool areRowsWithEqualLenght = AreRowsWithEqualLenght(jaggedArrayCombined);

            if (areRowsWithEqualLenght)
            {
                PrintJaggedArray(jaggedArrayCombined);
            }
            else
            {
                PrintTotalEmentsCountOfJaggedArray(jaggedArrayCombined);
            }
        }

        private static void PrintTotalEmentsCountOfJaggedArray(long[][] jaggedArrayCombined)
        {
            long elementCount = 0;
            for (int i = 0; i < jaggedArrayCombined.Length; i++)
            {
                elementCount += jaggedArrayCombined[i].Length;
            }
            Console.WriteLine($"The total number of cells is: {elementCount}");
        }

        private static void PrintJaggedArray(long[][] jaggedArrayCombined)
        {
            for (int i = 0; i < jaggedArrayCombined.Length; i++)
            {
                Console.Write("[");
                Console.Write(String.Join(", ", jaggedArrayCombined[i]));
                Console.WriteLine("]");
            }
            Console.WriteLine();
        }

        private static bool AreRowsWithEqualLenght(long[][] jaggedArrayCombined)
        {
            bool areRowLenghtsEqual = false;

            for (int i = 0; i < jaggedArrayCombined.Length - 1; i++)
            {
                areRowLenghtsEqual = jaggedArrayCombined[i].Length == jaggedArrayCombined[i + 1].Length;
            }

            return areRowLenghtsEqual;
        }
    }
}