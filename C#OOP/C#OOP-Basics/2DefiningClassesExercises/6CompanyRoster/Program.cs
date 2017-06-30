namespace _6CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<Employee>> dictionary = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string name = data[0];
                decimal salary = decimal.Parse(data[1]);
                string position = data[2];
                string department = data[3];

                List<Employee> employees = new List<Employee>();
                int age;

                if (data.Length == 6)
                {
                    string email = data[4];
                    age = int.Parse(data[5]);

                    Employee employee = new Employee(name, salary, position, department, email, age);
                    employees.Add(employee);
                }

                else if (data.Length == 5 && !int.TryParse(data[4], out age))
                {
                    string email = data[4];
                    Employee employee = new Employee(name, salary, position, department, email);
                    employees.Add(employee);
                }

                else if (data.Length == 5 && int.TryParse(data[4], out age))
                {
                    Employee employee = new Employee(name, salary, position, department, age);
                    employees.Add(employee);
                }

                else
                {
                    Employee employee = new Employee(name, salary, position, department);
                    employees.Add(employee);
                }



                if (!dictionary.ContainsKey(department))
                {
                    dictionary.Add(department, employees);
                }

                else
                {
                    dictionary[department].AddRange(employees);
                }
            }

            foreach (var pair in dictionary.OrderByDescending(x => x.Value.Average(z => z.Salary)).Take(1))
            {
                Console.WriteLine($"Highest Average Salary: {pair.Key}");
                foreach (var employee in pair.Value.OrderByDescending(x => x.Salary))
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
                }
            }
        }
    }
}