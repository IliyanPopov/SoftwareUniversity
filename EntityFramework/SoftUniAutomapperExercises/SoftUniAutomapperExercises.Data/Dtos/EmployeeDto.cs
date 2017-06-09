namespace SoftUniAutomapperExercises.Data.Dtos
{
    using System;
    using SoftUniAutomapperExercises.Data.Models;

    public class EmployeeDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public string ManagerLastName { get; set; }
    }
}