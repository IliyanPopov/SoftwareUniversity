namespace _13FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            string firstLine = Console.ReadLine();

            if (firstLine.Contains("/"))
            {
                string birthday = firstLine;
                Person person = new Person
                {
                    Birthday = birthday
                };
                people.Add(person);
            }
            else
            {
                string name = firstLine;
                Person person = new Person
                {
                    Name = name
                };
                people.Add(person);
            }

            string input = Console.ReadLine();
            List<string> allLines = new List<string>();
            // allLines.Add(input);
            while (input != "End")
            {
                allLines.Add(input);
                input = Console.ReadLine();
            }

            foreach (var line in allLines)
            {
                if (!line.Contains("-"))
                {
                    var data = line
                        .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    string fullName = data[0] + " " + data[1];
                    string birthday = data[2];

                    Person person = new Person(fullName, birthday);

                    if (!(people.Any(p => p.Name == fullName || p.Birthday == birthday)))
                    {
                        people.Add(person);
                    }
                    else
                    {
                        var personResult = people.FirstOrDefault(p => p.Name == fullName || p.Birthday == birthday);
                        personResult.Name = fullName;
                        personResult.Birthday = birthday;
                    }
                }
            }
            foreach (var line in allLines)
            {
                if (line.Contains("-"))
                {
                    if (line.Contains("/"))
                    {
                        var data = line
                            .Split(new string[] {" ", "-"}, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

                        Person child;
                        Person parent;
                        if (data[0].Contains("/") && !data[1].Contains("/") /*&&data.Count == 2*/)
                        {
                            string parentBirthday = data[0];
                            parent = people.FirstOrDefault(p => p.Birthday == parentBirthday);

                            string childName = data[1] + " " + data[2];
                            child = people.FirstOrDefault(p => p.Name == childName);
                        }
                        else if (!data[0].Contains("/") && data[2].Contains("/") && data.Count > 2)
                        {
                            string parentName = data[0] + " " + data[1];
                            parent = people.FirstOrDefault(p => p.Name == parentName);

                            string childBirthday = data[2];
                            child = people.FirstOrDefault(p => p.Birthday == childBirthday);
                        }
                        else
                        {
                            string parentBirthday = data[0];
                            parent = people.FirstOrDefault(p => p.Birthday == parentBirthday);

                            string childBirthday = data[1];
                            child = people.FirstOrDefault(p => p.Birthday == childBirthday);
                        }

                        // TODO: additional checks with data lenght, need to fit all cases


                        child.Parents.Add(parent);
                        parent.Children.Add(child);
                    }
                    else
                    {
                        var data = line
                            .Split(new string[] {" ", "-"}, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

                        string parentName = data[0] + " " + data[1];
                        string childName = data[2] + " " + data[3];

                        Person child = people.FirstOrDefault(p => p.Name == childName);
                        Person parent = people.FirstOrDefault(p => p.Name == parentName);

                        child.Parents.Add(parent);
                        parent.Children.Add(child);
                    }
                }
            }

            Person personFinalResult = people.FirstOrDefault(p => p.Name == firstLine || p.Birthday == firstLine);
            Console.WriteLine($"{personFinalResult.Name} {personFinalResult.Birthday}");
            Console.WriteLine($"Parents:");

            foreach (var parent in personFinalResult.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");
            }
            Console.WriteLine($"Children:");
            foreach (var child in personFinalResult.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }
    }
}