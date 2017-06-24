namespace _4CubicAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> meteorNames = new List<string> {"Green", "Red", "Black"};

            long treshHold = 1000000;
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> dictionary =
                new Dictionary<string, Dictionary<string, long>>();

            while (input != "Count em all")
            {
                var data = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string regionName = data[0];
                string meteorType = data[1];
                long meteorAmount = long.Parse(data[2]);


                if (!dictionary.ContainsKey(regionName))
                {
                    dictionary.Add(regionName, new Dictionary<string, long>
                    {
                        {
                            "Green",
                            0
                        },
                        {
                            "Red",
                            0
                        },
                        {
                            "Black",
                            0
                        }
                    });
                }

                dictionary[regionName][meteorType] += meteorAmount;

                for (int i = 0; i < meteorNames.Count - 1; i++)
                {
                    var nextTypeCount = dictionary[regionName][meteorNames[i]] / treshHold;
                    if (nextTypeCount > 0)
                    {
                        dictionary[regionName][meteorNames[i + 1]] += nextTypeCount;
                        dictionary[regionName][meteorNames[i]] %= treshHold;
                    }
                }

                input = Console.ReadLine();
            }

            var orderedRegiens = dictionary
                .OrderByDescending(x => x.Value["Black"])
                .ThenBy(x => x.Key.Length)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in orderedRegiens)
            {
                Console.WriteLine(pair.Key);

                foreach (var meteorType in pair.Value.OrderByDescending(x =>x.Value)
                    .ThenBy(x =>x.Key))
                {
                    Console.WriteLine($"-> {meteorType.Key} : {meteorType.Value}");
                }
            }
        }
    }
}