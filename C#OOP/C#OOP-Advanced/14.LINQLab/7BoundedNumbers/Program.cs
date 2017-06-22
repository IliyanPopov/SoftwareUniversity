namespace _7BoundedNumbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var lowerBound = data.Min();
            var upperBound = data.Max();

            var numbers = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            numbers.Where(x => lowerBound <= x && x <= upperBound)
                .ToList()
                .ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
        }
    }
}