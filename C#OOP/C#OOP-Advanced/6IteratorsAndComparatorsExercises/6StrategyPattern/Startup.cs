using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        SortedSet<Person> peopleSortedWithNameComparator = new SortedSet<Person>(new NameLenghtComparator());

        SortedSet<Person> peopleSortedWithAgeComparator = new SortedSet<Person>(new AgeComparator());

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var personData = Console.ReadLine().Split();

            Person person = new Person(personData[0], int.Parse(personData[1]));

            peopleSortedWithNameComparator.Add(person);
            peopleSortedWithAgeComparator.Add(person);
        }

        foreach (var person in peopleSortedWithNameComparator)
        {
            Console.WriteLine(person);
        }

        foreach (var person in peopleSortedWithAgeComparator)
        {
            Console.WriteLine(person);
        }
    }
}

