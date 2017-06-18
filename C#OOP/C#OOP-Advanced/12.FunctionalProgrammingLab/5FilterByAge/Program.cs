namespace _5FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = data[0];
                int personAge = int.Parse(data[1]);

                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, personAge);
                }
                dictionary[name] = personAge;
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();


            //Implementation of these methos on next slides 

            Func<int, bool> tester = CreateTester(condition, age);
            Action<KeyValuePair<string, int>> printer =
                CreatePrinter(format);

            PrintFilteredStudent(dictionary, tester, printer);
        }

        private static void PrintFilteredStudent(Dictionary<string, int> dictionary, Func<int, bool> tester,
            Action<KeyValuePair<string, int>> printer)
        {
            foreach (var pair in dictionary)
            {
                if (tester(pair.Value))
                {
                    printer(pair);
                }
            }
        }

        public static Func<int, bool> CreateTester
            (string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x < age;
                case "older": return x => x >= age;
                default: return null;
            }
        }

        public static Action<KeyValuePair<string, int>>
            CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return person => Console.WriteLine($"{person.Key}");
                case "age":
                    return person => Console.WriteLine($"{person.Value}");
                case "name age":
                    return person =>
                        Console.WriteLine($"{person.Key} - {person.Value}");
                default: return null;
            }
        }
    }
}