namespace _5PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            while (input != "search")
            {
                string[] data = input.Trim().Split('-')
                    .ToArray();

                string name = data[0];
                string number = data[1];

                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, number);
                }
                else
                {
                    dictionary[name] = number;
                }
                input = Console.ReadLine();
            }

            while (input != "stop")
            {
                string name = input;

                if (input != "search")
                {
                    if (dictionary.ContainsKey(name))
                    {
                        string result = string.Empty;
                        Console.WriteLine($"{name} -> {dictionary[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}