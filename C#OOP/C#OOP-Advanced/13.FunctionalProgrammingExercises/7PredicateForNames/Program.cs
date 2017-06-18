namespace _7PredicateForNames
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var data = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, bool> filterByAge = x => x.Length <= n;
            Console.WriteLine(string.Join(Environment.NewLine, data.Where(filterByAge)));
        }
    }
}