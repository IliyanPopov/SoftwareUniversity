namespace _4AddVAT
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var result = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .Select(x => x * 1.2);

            foreach (var number in result)
            {
                Console.WriteLine($"{number:F2}");
            }
        }
    }
}