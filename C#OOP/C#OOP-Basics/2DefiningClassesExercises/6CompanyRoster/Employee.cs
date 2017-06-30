namespace _6CompanyRoster
{
    public class Employee
    {
        private const int DefaultAge = -1;
        private const string DefaultEmail = "n/a";

        public Employee(string name, decimal salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Age = DefaultAge;
            this.Email = DefaultEmail;
        }

        public Employee(string name, decimal salary, string position, string department, string email)
            : this(name, salary, position, department)
        {
            this.Email = email;
            this.Age = DefaultAge;
        }

        public Employee(string name, decimal salary, string position, string department, int age)
            : this(name, salary, position, department)
        {
            this.Age = age;
            this.Email = DefaultEmail;
        }

        public Employee(string name, decimal salary, string position, string department, string email, int age)
            : this(name, salary, position, department)
        {
            this.Email = email;
            this.Age = age;
        }

        public Employee()
        {
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Position { get; set; }

        public string Department { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }
    }
}