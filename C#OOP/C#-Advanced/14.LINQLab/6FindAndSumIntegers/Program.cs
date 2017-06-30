namespace _6FindAndSumIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<long> numbers = new List<long>();

            foreach (var element in data)
            {
                long number;
                if (long.TryParse(element, out number))
                {
                    numbers.Add(number);
                }
            }

            if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}