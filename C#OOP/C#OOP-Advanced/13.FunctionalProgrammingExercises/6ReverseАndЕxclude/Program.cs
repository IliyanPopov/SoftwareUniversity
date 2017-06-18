namespace _6ReverseАndЕxclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            double divisor = double.Parse(Console.ReadLine());

            Predicate<double> divisorPredicate = x => x % divisor == 0;

            numbers.RemoveAll(divisorPredicate);
            numbers.Reverse();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}