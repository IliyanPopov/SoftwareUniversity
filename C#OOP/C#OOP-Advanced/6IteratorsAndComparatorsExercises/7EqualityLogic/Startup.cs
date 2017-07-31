using System;
using System.Collections.Generic;

public class Startup
{
    static void Main()
    {
        SortedSet<Person> people = new SortedSet<Person>();
        HashSet<Person> peopleHashSet = new HashSet<Person>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split();

            Person person = new Person(data[0], int.Parse(data[1]));
            people.Add(person);
            peopleHashSet.Add(person);
        }

        Console.WriteLine(people.Count);
        Console.WriteLine(peopleHashSet.Count);
    }
}

