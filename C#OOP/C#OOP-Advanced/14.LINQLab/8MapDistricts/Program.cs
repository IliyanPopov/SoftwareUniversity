namespace _8MapDistricts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine()
                .Split(new string[] { ":", " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, List<long>> dictionary = new Dictionary<string, List<long>>();

            for (int i = 0; i < data.Count; i += 2)
            {
                string cityName = data[i];
                long countPeopleInDistrict = long.Parse(data[i + 1]);
                List<long> tempList = new List<long>();

                tempList.Add(countPeopleInDistrict);
                if (!dictionary.ContainsKey(cityName))
                {
                    dictionary.Add(cityName, tempList);
                }
                else
                {
                    dictionary[cityName].AddRange(tempList);
                }
            }

            long upperPeopleBound = long.Parse(Console.ReadLine());

            //dictionary.OrderByDescending(pair => pair.Value.Sum())
            //    .Where(pair => pair.Value.Sum() > upperPeopleBound)


            foreach (var pair in dictionary.OrderByDescending(x => x.Value.Sum()))
            {

                if (pair.Value.Sum() > upperPeopleBound)
                {
                    Console.WriteLine($"{pair.Key}: {string.Join(" ", pair.Value.OrderByDescending(x => x).Take(5).ToList())}");
                }
            }
        }
    }
}