namespace SoftUniAutomapperExercises.Data.Dtos
{
    using System;
    using System.Collections.Generic;
    using SoftUniAutomapperExercises.Data.Models;

    public class ManagerDto
    {
        private ICollection<ManagerDto> _lowerRankEmployees;

        public ManagerDto()
        {
            this._lowerRankEmployees = new HashSet<ManagerDto>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<ManagerDto> LowerRankEmployees
        {
            get { return this._lowerRankEmployees; }
            set { this._lowerRankEmployees = value; }
        }

        public int GetLowerRankEmployeesCount()
        {
            return this._lowerRankEmployees.Count;
        }
    }
}

