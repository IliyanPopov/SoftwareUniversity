namespace _4CountSymbols
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, long> dictionary = new SortedDictionary<char, long>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    dictionary.Add(input[i], 1);
                }
                else
                {
                    dictionary[input[i]]++;
                }
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s ");
            }
        }
    }
}