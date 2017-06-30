namespace _4AverageOfDoubles
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            Console.WriteLine($"{numbers.Average():F2}");
        }
    }
}