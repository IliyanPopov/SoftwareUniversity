namespace _10UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, User> dictionary = new Dictionary<string, User>();

            while (input != "end")
            {
                string[] data = input.Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string ip = data[1];
                string name = data[5];

                var user = new User();
                user.IP = ip;
                user.Name = name;
                user.IpRepeatedCount.Add(ip, 1);

                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, user);
                }
                else
                {
                    if (dictionary[name].IpRepeatedCount.ContainsKey(ip))
                    {
                        dictionary[name].IpRepeatedCount[ip]++;
                    }
                    else
                    {
                        dictionary[name].IpRepeatedCount.Add(ip, 1);
                    }
                }

                input = Console.ReadLine();
            }

            
            foreach (var pair in dictionary.OrderBy(x =>x.Key))
            {
                var last = pair.Value.IpRepeatedCount.Last();

                Console.WriteLine($"{pair.Key}:");
                //Console.WriteLine($"{String.Join(", ", pair.Value.IpRepeatedCount.Keys)}.");

                foreach (var pairNested in pair.Value.IpRepeatedCount)
                {
                   
                    if (pairNested.Key == last.Key)
                    {
                        Console.WriteLine($"{pairNested.Key} => {pairNested.Value}.");
                    }
                    else
                    {
                        Console.Write($"{pairNested.Key} => {pairNested.Value}, ");
                    }
                }
            }
        }
    }

    public class User
    {
        public User()
        {
            this.IpRepeatedCount = new Dictionary<string, long>();
        }

        public string Name { get; set; }

        public string IP { get; set; }

        public string Message { get; set; }

        public Dictionary<string, long> IpRepeatedCount { get; set; }
    }
}