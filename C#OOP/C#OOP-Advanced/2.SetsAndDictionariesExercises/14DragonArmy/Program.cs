namespace _14DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, DragonType> dictionary = new Dictionary<string, DragonType>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = data[0];
                string name = data[1];
                long damage;
                long health;
                long armor;
                if (!long.TryParse(data[2], out damage))
                {
                    damage = 45;
                }

                if (!long.TryParse(data[3], out health))
                {
                    health = 250;
                }

                if (!long.TryParse(data[4], out armor))
                {
                    armor = 10;
                }

                DragonType dragonType = new DragonType
                {
                    Name = name
                };

                Dragon dragon = new Dragon
                {
                    Name = name,
                    Armor = armor,
                    Damage = damage,
                    Health = health
                };

                dragonType.Dragons.Add(dragon);

                if (!dictionary.ContainsKey(type))
                {
                    dictionary.Add(type, dragonType);
                }

                if (!dictionary[type].Dragons.Any(d =>d.Name == name))
                {
                    dictionary[type].Dragons.Add(dragon);
                }
                else
                {
                    var dragonToRemove = dictionary[type].Dragons.First(d => d.Name == name);
                    dictionary[type].Dragons.Remove(dragonToRemove);
                    dictionary[type].Dragons.Add(dragon);
                }
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine(
                    $"{pair.Key}::({pair.Value.Dragons.Average(d => d.Damage):F2}/{pair.Value.Dragons.Average(d => d.Health):F2}/{pair.Value.Dragons.Average(d => d.Armor):F2})");

                foreach (var nestedPair in pair.Value.Dragons.OrderBy(d => d.Name))
                {
                    Console.WriteLine(
                        $"-{nestedPair.Name} -> damage: {nestedPair.Damage}, health: {nestedPair.Health}, armor: {nestedPair.Armor}");
                }
            }
        }
    }

    public class DragonType
    {
        public DragonType()
        {
            this.Dragons = new HashSet<Dragon>();
        }

        public string Name { get; set; }

        public HashSet<Dragon> Dragons { get; set; }
    }

    public class Dragon
    {
        public string Name { get; set; }

        public long Damage { get; set; }

        public long Health { get; set; }

        public long Armor { get; set; }
    }
}