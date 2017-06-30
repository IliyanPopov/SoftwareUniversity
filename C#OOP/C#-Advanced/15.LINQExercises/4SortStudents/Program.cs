namespace _4SortStudents
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


                Student student = new Student
                {
                    FirstName = name,
                    LastName = lastName,
                };

                students.Add(student);

                input = Console.ReadLine();
            }

            students.OrderBy(x => x.LastName).ThenByDescending(x => x.FirstName)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName}"));
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long Age { get; set; }
    }
}