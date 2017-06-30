namespace _11StudentsJoinedToSpecialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<StudentSpecialty> studentSpecialties = new List<StudentSpecialty>();
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "Students:")
            {
                var data = input.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string specialtyNamePart1 = data[0];
                string specialtyNamePart2 = data[1];
                string specialtyName = specialtyNamePart1 + " " + specialtyNamePart2;
                int number = int.Parse(data[2]);

                StudentSpecialty studentSpecialty = new StudentSpecialty
                {
                    Name = specialtyName,
                    FacultyNumber = number
                };

                studentSpecialties.Add(studentSpecialty);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                var data = input.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                int number = int.Parse(data[0]);
                string firstName = data[1];
                string lastName = data[2];
                string name = firstName + " " + lastName;

                Student student = new Student
                {
                    Name = name,
                    FacultyNumber = number
                };

                students.Add(student);

                input = Console.ReadLine();
            }


            var query = studentSpecialties // your starting point - table in the "from" statement
                .Join(students, // the source table of the inner join
                    specialty => specialty
                        .FacultyNumber, // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                    student => student.FacultyNumber, // Select the foreign key (the second part of the "on" clause)
                    (specialty, student) => new {Specialty = specialty, Student = student}) // selection
                .OrderBy(x => x.Student.Name);

            foreach (var mix in query)
            {
                Console.WriteLine($"{mix.Student.Name} {mix.Student.FacultyNumber} {mix.Specialty.Name}");
            }
        }
    }

    public class StudentSpecialty
    {
        public string Name { get; set; }

        public int FacultyNumber { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }

        public int FacultyNumber { get; set; }
    }
}


//var id = 1;
//var query = database.Posts    // your starting point - table in the "from" statement
//.Join(database.Post_Metas, // the source table of the inner join
//post => post.ID,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
//meta => meta.Post_ID,   // Select the foreign key (the second part of the "on" clause)
//(post, meta) => new { Post = post, Meta = meta }) // selection
//.Where(postAndMeta => postAndMeta.Post.ID == id);    // where statement