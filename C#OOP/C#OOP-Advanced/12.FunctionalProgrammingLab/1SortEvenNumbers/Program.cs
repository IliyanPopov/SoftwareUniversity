namespace _1SortEvenNumbers
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            Func<string, int> intParser = x => int.Parse(x);
            Func<int, bool> evenNumbersSelector = x => x % 2 == 0;

            var result = Console.ReadLine()
                .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(intParser)
                .Where(evenNumbersSelector)
                .OrderBy(x => x);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}