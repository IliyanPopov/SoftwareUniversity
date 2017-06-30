namespace _4OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _3OldestFamilyMember;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split(' ');

                Person person = new Person
                {
                    name = data[0],
                    age = int.Parse(data[1])
                };

                people.Add(person);
            }

            people.Where(x => x.age > 30)
                .OrderBy(x => x.name)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.name} - {x.age}"));
        }
    }
}