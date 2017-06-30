namespace _4SpecialWords
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            char[] decimilers = new[] { '(', ')', '[', ']', '<', '>', ',', '!', '?', ' ' };

            string[] specialWords = Console.ReadLine()
                .Split(decimilers, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var specialWord in specialWords)
            {
                dictionary.Add(specialWord, 0);
            }

            string[] text = Console.ReadLine()
                .Split(decimilers, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in text)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}