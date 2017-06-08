namespace _3CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input
                .Trim()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            SortedDictionary<double, int> sortedNumbers = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!sortedNumbers.ContainsKey(numbers[i]))
                {
                    sortedNumbers.Add(numbers[i], 1);
                }
                else
                {
                    sortedNumbers[numbers[i]]++;
                }
            }

            foreach (KeyValuePair<double, int> sortedNumber in sortedNumbers)
            {
                Console.WriteLine($"{sortedNumber.Key} - {sortedNumber.Value} times");
            }
        }
    }
}