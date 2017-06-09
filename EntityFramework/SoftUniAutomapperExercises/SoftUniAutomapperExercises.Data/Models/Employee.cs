namespace SoftUniAutomapperExercises.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Employee
    {
        private ICollection<Employee> _employees;

        public Employee()
        {
            this._employees = new HashSet<Employee>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }
        public virtual Employee Manager { get; set; }

        public virtual ICollection<Employee> LowerRankEmployees
        {
            get { return this._employees; }
            set { this._employees = value; }
        }
    }
}