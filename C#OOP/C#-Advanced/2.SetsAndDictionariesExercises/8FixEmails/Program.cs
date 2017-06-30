namespace _8FixEmails
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            while (input != "stop")
            {
                string name = input;
                string email = Console.ReadLine();

                if (!(email.EndsWith("us") || email.EndsWith("uk")))
                {
                    if (!dictionary.ContainsKey(name))
                    {
                        dictionary.Add(name, email);
                    }
                    else
                    {
                        dictionary[name] = email;
                    }
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