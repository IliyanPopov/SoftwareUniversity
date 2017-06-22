namespace StudentsByAge
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
                long age = long.Parse(data[2]);

                Student student = new Student
                {
                    FirstName = name,
                    LastName = lastName,
                    Age = age
                };

                students.Add(student);

                input = Console.ReadLine();
            }

            students.Where(x => 18 <= x.Age && x.Age <= 24)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} {x.Age}"));
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long Age { get; set; }
    }
}