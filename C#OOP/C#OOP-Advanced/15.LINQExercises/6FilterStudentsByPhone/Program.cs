using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6FilterStudentsByPhone
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var data = input
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string name = data[0];
                string lastName = data[1];
                string phoneNumber = data[2];

                Student student = new Student
                {
                    FirstName = name,
                    LastName = lastName,
                    PhoneNumber = phoneNumber
                };

                students.Add(student);

                input = Console.ReadLine();
            }

            students.Where(x => x.PhoneNumber.StartsWith("02") || x.PhoneNumber.StartsWith("+3592"))
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName}"));
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
    }
}
