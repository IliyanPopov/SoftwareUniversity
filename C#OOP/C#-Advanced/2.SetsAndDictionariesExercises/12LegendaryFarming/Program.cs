namespace _12LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> legendaryDictionary = new Dictionary<string, long>();
            Dictionary<string, long> junkDictionary = new Dictionary<string, long>();

            legendaryDictionary.Add("shards", 0);
            legendaryDictionary.Add("fragments", 0);
            legendaryDictionary.Add("motes", 0);

            while (true)
            {
                string[] data = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < data.Length; i += 2)
                {
                    long materialCount = long.Parse(data[i]);
                    string material = data[i + 1].ToLower();

                    if (IsKeyMaterial(material))
                    {
                        if (!legendaryDictionary.ContainsKey(material))
                        {
                            legendaryDictionary.Add(material, materialCount);
                        }
                        else
                        {
                            legendaryDictionary[material] += materialCount;
                        }

                        if (legendaryDictionary[material] >= 250)
                        {
                            legendaryDictionary[material] -= 250;

                            Console.WriteLine(PrintKeyMaterial(material));

                            foreach (var pair in legendaryDictionary.OrderByDescending(x => x.Value).ThenBy(x =>x.Key))
                            {
                                Console.WriteLine($"{pair.Key}: {pair.Value}");
                            }

                            foreach (var pair in junkDictionary.OrderBy(x => x.Key))
                            {
                                Console.WriteLine($"{pair.Key}: {pair.Value}");
                            }

                            return;
                        }
                    }
                    else
                    {
                        if (!junkDictionary.ContainsKey(material))
                        {
                            junkDictionary.Add(material, materialCount);
                        }
                        else
                        {
                            junkDictionary[material] += materialCount;
                        }
                    }
                }
            }
        }

        private static string PrintKeyMaterial(string material)
        {
            switch (material)
            {
                case "shards":
                    return "Shadowmourne obtained!";
                case "fragments":
                    return "Valanyr obtained!";
                case "motes":
                    return "Dragonwrath obtained!";
                default:
                    return "Not key material";
            }
        }

        private static bool IsKeyMaterial(string material)
        {
            switch (material.ToLower())
            {
                case "shards":
                    return true;
                case "fragments":
                    return true;
                case "motes":
                    return true;
            }
            return false;
        }
    }
}