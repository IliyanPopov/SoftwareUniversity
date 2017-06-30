namespace _7ExcellentStudents
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

                List<long> marks = new List<long>();

                for (int i = 2; i < data.Count; i++)
                {
                    marks.Add(long.Parse(data[i]));
                }

                Student student = new Student
                {
                    Firstname = name,
                    Lastname = lastName,
                    Marks = marks
                };

                students.Add(student);

                input = Console.ReadLine();
            }

            students.Where(x => x.Marks.Any(m => m == 6))
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Firstname} {x.Lastname}"));
        }
    }

    public class Student
    {
        public Student()
        {
            this.Marks = new List<long>();
        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public List<long> Marks { get; set; }
    }
}