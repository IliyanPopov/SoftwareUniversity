namespace _2CubicRube
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            long n = int.Parse(Console.ReadLine());

            long[,,] matrixCube = new long[n, n, n];

            string input = Console.ReadLine();

            while (input != "Analyze")
            {
                var data = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                long d1 = long.Parse(data[0]);
                long d2 = long.Parse(data[1]);
                long d3 = long.Parse(data[2]);
                long valueToAdd = long.Parse(data[3]);

                if (CheckIfInRange(n, d1, d2, d3))
                {
                    matrixCube[d1, d2, d3] = valueToAdd;
                }


                input = Console.ReadLine();
            }

            long sum = matrixCube.Cast<long>().Sum();

            int numberOfEmptyCells = matrixCube.Cast<long>().Count(x => x == 0);

            Console.WriteLine(sum);
            Console.WriteLine(numberOfEmptyCells);
        }

        public static bool CheckIfInRange(long number, long d1, long d2, long d3)
        {
            if (d1 >= 0 && d1 <= number && d2 >= 0 && d2 <= number && d3 >= 0 && d3 <= number)
            {
                return true;
            }
            return false;
        }
    }
}