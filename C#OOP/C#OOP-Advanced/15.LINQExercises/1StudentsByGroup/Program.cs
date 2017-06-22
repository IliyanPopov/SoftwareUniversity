namespace _1StudentsByGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var data = input
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string name = data[0];
                string lastName = data[1];
                long groupNumber = long.Parse(data[2]);

                Student student = new Student
                {
                    FirstName = name,
                    LastName = lastName,
                    Group = groupNumber
                };

                students.Add(student);

                input = Console.ReadLine();
            }

            students.Where(s => s.Group == 2)
                .OrderBy(s => s.FirstName)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName} "));
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long Group { get; set; }
    }
}