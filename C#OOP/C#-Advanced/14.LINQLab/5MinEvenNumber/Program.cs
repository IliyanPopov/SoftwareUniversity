namespace _5MinEvenNumber
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


            if (numbers.Any(x => x % 2 == 0))
            {
                var result = numbers.Where(x => x % 2 == 0).Min();

                Console.WriteLine($"{result:F2}");
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}