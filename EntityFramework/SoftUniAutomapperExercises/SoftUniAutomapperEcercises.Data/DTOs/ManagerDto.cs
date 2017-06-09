namespace SoftUniAutomapperEcercises.Data.DTOs
{
    using System.Collections.Generic;
    using SoftUniAutomapperEcercises.Data.Models;

    public class ManagerDto
    {
        public ManagerDto()
        {
            this.LowerRankEmployees = new HashSet<ManagerDto>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<ManagerDto> LowerRankEmployees { get; set; }
    }
}