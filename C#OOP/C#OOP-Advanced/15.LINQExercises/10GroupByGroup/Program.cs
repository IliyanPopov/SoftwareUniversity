namespace _10GroupByGroup
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
                var data = input.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string firstName = data[0];
                string lastName = data[1];
                string fullName = firstName + " " + lastName;
                int group = int.Parse(data[2]);


                Student student = new Student
                {
                    Name = fullName,
                    Group = group
                };


                students.Add(student);

                input = Console.ReadLine();
            }

            var results = students.GroupBy(s => s.Group, s => s.Name,
                (key, name) => new {Group = key, Name = name.ToList()});

            foreach (var result in results.OrderBy(x => x.Group))
            {
                Console.WriteLine($"{result.Group} - {string.Join(", ", result.Name)}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public int Group { get; set; }
    }
}