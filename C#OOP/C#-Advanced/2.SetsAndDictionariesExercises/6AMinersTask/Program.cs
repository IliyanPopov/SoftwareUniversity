namespace _6AMinersTask
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, long> dictionary = new Dictionary<string, long>();

            while (input != "stop")
            {
                long resourses = long.Parse(Console.ReadLine());


                if (!dictionary.ContainsKey(input))
                {
                    dictionary.Add(input, 0);
                }

                if (dictionary.ContainsKey(input))
                {
                    dictionary[input] += resourses;
                }

                input = Console.ReadLine();
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}