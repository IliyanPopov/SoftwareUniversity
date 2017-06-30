﻿namespace _12Google
{
    using System;

    public class Company
    {
        public Company(string name, string department, decimal salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }

        public string Name { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Environment.NewLine} {this.Name} {this.Department} {this.Salary:F2}";
        }
    }
}