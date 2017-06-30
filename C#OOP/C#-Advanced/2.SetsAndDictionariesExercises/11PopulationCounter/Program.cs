namespace _11PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Country> dictionary = new SortedDictionary<string, Country>();

            while (input != "report")
            {
                string[] data = input
                    .Split('|')
                    .ToArray();

                string countryName = data[1];
                string cityName = data[0];
                long population = long.Parse(data[2]);

                Dictionary<string, long> cityAndPopulation = new Dictionary<string, long>();
                cityAndPopulation.Add(cityName, population);

                Country country = new Country
                {
                    Name = countryName,
                    CitiesAndPopulation = cityAndPopulation
                };

                if (!dictionary.ContainsKey(countryName))
                {
                    dictionary.Add(countryName, country);
                }

                else
                {
                    if (!dictionary[countryName].CitiesAndPopulation.ContainsKey(cityName))
                    {
                        dictionary[countryName].CitiesAndPopulation.Add(cityName, population);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pair in dictionary.OrderByDescending(x => x.Value.CitiesAndPopulation.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.CitiesAndPopulation.Values.Sum()})");

                foreach (var nestedPair in pair.Value.CitiesAndPopulation.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{nestedPair.Key}: {nestedPair.Value}");
                }
            }
        }
    }

    public class Country
    {
        public Country()
        {
            this.CitiesAndPopulation = new Dictionary<string, long>();
        }

        public string Name { get; set; }

        public Dictionary<string, long> CitiesAndPopulation { get; set; }
    }
}