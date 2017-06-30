namespace _10PredicateParty_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var people = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] data = input
                    .Trim()
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

                var command = data[0];
                var criteria = data[1];
                var value = data[2];

                if (command == "Remove")
                {
                    var tester = RemoveTester(criteria, value);
                    tester.Invoke(people);
                }
                else if (command == "Double")
                {
                    var s = AddTester(criteria, value);
                    var result = s.Invoke(people);
                    people.AddRange(result);
                }
                input = Console.ReadLine();
            }

            if (people.Count > 0)
            {
                Console.WriteLine(string.Join(", ", people.OrderBy(x => x)) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        public static Func<List<string>, int> RemoveTester
            (string criteria, string value)
        {
            switch (criteria)
            {
                case "StartsWith":
                    return x => x.RemoveAll(y => y.StartsWith(value));
                case "EndsWith":
                    return x => x.RemoveAll(y => y.EndsWith(value));
                case "Length":
                    return x => x.RemoveAll(y => y.Length == int.Parse(value));
                default:
                    return x => x.Count;
            }
        }

        public static Func<List<string>, List<string>> AddTester
            (string criteria, string value)
        {
            switch (criteria)
            {
                case "StartsWith":
                    return x => x.Where(y => y.StartsWith(value)).ToList();
                case "EndsWith":
                    return x => x.Where(y => y.EndsWith(value)).ToList();
                case "Length":
                    return x => x.Where(y => y.Length == int.Parse(value)).ToList();
                default:
                    return x => x;
            }
        }
    }
}