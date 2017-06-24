namespace _4AshesOfRoses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> dictionary =
                new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "Icarus, Ignite!")
            {
                string pattern = @"^(Grow\s<([A-Z][a-z]*)>\s<([a-zA-Z0-9]+)>\s(\d+))$";

                foreach (Match match in Regex.Matches(input, pattern))
                {
                    var regionName = match.Groups[2].Value;
                    var colorName = match.Groups[3].Value;
                    long roseAmount = long.Parse(match.Groups[4].Value);

                    if (!dictionary.ContainsKey(regionName))
                    {
                        dictionary.Add(regionName, new Dictionary<string, long>());
                    }
                    if (!dictionary[regionName].ContainsKey(colorName))
                    {
                        dictionary[regionName].Add(colorName, roseAmount);
                    }
                    else
                    {
                        dictionary[regionName][colorName] += roseAmount;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine();

            foreach (var pair in dictionary.OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}");
                foreach (var nestedPair in pair.Value.OrderBy(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"*--{nestedPair.Key} | {nestedPair.Value}");
                }
            }
        }
    }
}