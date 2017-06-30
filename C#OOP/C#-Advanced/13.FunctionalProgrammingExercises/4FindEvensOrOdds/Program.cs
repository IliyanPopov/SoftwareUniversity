namespace _4FindEvensOrOdds
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] data = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            decimal lowerBound = decimal.Parse(data[0]);
            decimal upperBound = decimal.Parse(data[1]);
            string command = Console.ReadLine();

            List<decimal> numbers = new List<decimal>();
            for (decimal i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            Predicate<decimal> evenPredicate = x =>Math.Abs(x) % 2 == 0;
            Predicate<decimal> oddPredicate = x => Math.Abs(x) % 2 == 1;

            switch (command)
            {
                case "odd":
                    Console.WriteLine(string.Join(" ", numbers.FindAll(oddPredicate)));
                    break;
                case "even":
                    Console.WriteLine(string.Join(" ", numbers.FindAll(evenPredicate)));
                    break;
            }
        }
    }
}