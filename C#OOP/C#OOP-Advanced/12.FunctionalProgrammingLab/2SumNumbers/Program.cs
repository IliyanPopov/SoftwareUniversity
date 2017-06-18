namespace _2SumNumbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Func<string, int> intParser = x => int.Parse(x);
            var result = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(intParser);

            Console.WriteLine(result.Count());
            Console.WriteLine(result.Sum());
        }
    }
}