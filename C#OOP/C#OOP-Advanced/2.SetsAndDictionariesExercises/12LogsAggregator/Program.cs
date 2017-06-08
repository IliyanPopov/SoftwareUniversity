namespace _12LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, UserLog> dictionary = new Dictionary<string, UserLog>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Trim()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string ip = data[0];
                string name = data[1];
                long duaration = long.Parse(data[2]);
                Dictionary<string, long> ipDictionary = new Dictionary<string, long>();
                ipDictionary.Add(ip, duaration);

                UserLog userLog = new UserLog
                {
                    UserName = name,
                    Duaration = duaration,
                    IPDictionary = ipDictionary
                };

                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, userLog);
                }
                else
                {
                    if (dictionary[name].IPDictionary.ContainsKey(ip))
                    {
                        dictionary[name].IPDictionary[ip] += duaration;
                    }
                    else
                    {
                        dictionary[name].IPDictionary.Add(ip, duaration);
                    }
                }
            }

            foreach (var pair in dictionary.OrderBy(x => x.Key))
            {
                Console.Write($"{pair.Key}: {pair.Value.IPDictionary.Values.Sum()} ");

                Console.WriteLine($"[{String.Join(", ", pair.Value.IPDictionary.Keys.OrderBy(x => x))}]");
            }
        }
    }

    class UserLog
    {
        public UserLog()
        {
            this.IPDictionary = new Dictionary<string, long>();
        }

        public string UserName { get; set; }

        public long Duaration { get; set; }

        public Dictionary<string, long> IPDictionary { get; set; }
    }
}