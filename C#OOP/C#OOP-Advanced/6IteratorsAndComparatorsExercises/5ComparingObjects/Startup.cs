using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        int equalPeople = 1;
        int notEqualPeople = 0;

        List<Person> people = new List<Person>();

        var data = Console.ReadLine().Split();

        while (data[0] != "END")
        {
            Person person = new Person(data[0], int.Parse(data[1]), data[2]);
            people.Add(person);
            data = Console.ReadLine().Split();
        }

        int n = int.Parse(Console.ReadLine()) - 1;

        for (int i = 0; i < n; i++)
        {
            if (people[n].CompareTo(people[i]) == 0)
            {
                equalPeople++;
            }
            else
            {
                notEqualPeople++;
            }
        }

        for (int i = n + 1; i < people.Count; i++)
        {
            if (people[n].CompareTo(people[i]) == 0)
            {
                equalPeople++;
            }
            else
            {
                notEqualPeople++;
            }
        }

        if (equalPeople == 0)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{equalPeople} {notEqualPeople} {people.Count}");
        }
    }
}

