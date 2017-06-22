namespace _1TakeTwo
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

            data.Where(n => 10 <= n && n <= 20)
                .Distinct()
                .Take(2)
                .ToList()
                .ForEach(n => Console.Write($"{n} "));
        }
    }
}