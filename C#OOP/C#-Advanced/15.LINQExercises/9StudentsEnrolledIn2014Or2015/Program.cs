namespace _9StudentsEnrolledIn2014Or2015
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
                List<int> marks = new List<int>();
                var data = input.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string facultyNumber = data[0];

                for (int i = 1; i < data.Count; i++)
                {
                    marks.Add(int.Parse(data[i]));
                }

                Student student = new Student
                {
                    FacultyNumber = facultyNumber,
                    Marks = marks
                };

                students.Add(student);

                input = Console.ReadLine();
            }

            students.Where(x => x.FacultyNumber.EndsWith("14") || x.FacultyNumber.EndsWith("15"))
                .ToList()
                .ForEach(x => Console.WriteLine($"{string.Join(" ", x.Marks)}"));
        }
    }

    public class Student
    {
        public Student()
        {
            this.Marks = new List<int>();
        }

        public string FacultyNumber { get; set; }

        public List<int> Marks { get; set; }
    }
}