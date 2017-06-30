namespace _3CustomMinFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Func<List<double>, double> minNumber = n => n.Min();

            var numbers = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            Console.WriteLine(minNumber.Invoke(numbers));
        }
    }
}