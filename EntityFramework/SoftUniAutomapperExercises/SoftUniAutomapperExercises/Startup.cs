namespace SoftUniAutomapperExercises
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using SoftUniAutomapperExercises.Data;
    using SoftUniAutomapperExercises.Data.Dtos;
    using SoftUniAutomapperExercises.Data.Models;
    using System.Linq;
    using AutoMapper.QueryableExtensions;

    public class Startup
    {
        public static void Main()
        {

            Mapper.Initialize(cfg => cfg.CreateMap<Employee, EmployeeDto>()
            .ForMember(dto => dto.ManagerLastName, conf => conf.MapFrom(e => e.Manager.LastName)));

            using (var context = new EmployeeContext())
            {


                List<Employee> employees = new List<Employee>
                {
                    new Employee
                    {
                        FirstName = "firstEmployee",
                        LastName = "lastNEmployee",
                        Address = "FAdress",
                        Birthday = new DateTime(1995,2,5),
                        Salary = 100
                    },
                     new Employee
                    {
                        FirstName = "secondEmployee1",
                        LastName = "lastNEmployee1",
                        Address = "FAdress1",
                        Birthday = new DateTime(1995,2,5),
                        Salary = 100
                    },
                      new Employee
                    {
                        FirstName = "firstEmployee3",
                        LastName = "lastNEmployee3",
                        Address = "FAdress3",
                        Birthday = new DateTime(1985,2,5),
                        Salary = 100
                    },
                       new Employee
                    {
                        FirstName = "firstEmployee4",
                        LastName = "lastNEmployee4",
                        Address = "FAdress4",
                        Birthday = new DateTime(1975,2,5),
                        Salary = 100
                    }
                };

                //context.Employees.AddRange(employees);
                //context.SaveChanges();

                var targetDate = new DateTime(1990, 1, 1);


                var managers = context.Employees
                .Where(e => e.Birthday > targetDate)
                .ProjectTo<EmployeeDto>()
                .ToList();

                foreach (var managerDto in managers)
                {
                    Console.WriteLine($"{managerDto.FirstName} {managerDto.LastName}");
                }
            }



            //Console.WriteLine(dto.GetLowerRankEmployeesCount());
            //foreach (var lowerRankEmployee in dto.LowerRankEmployees)
            //{
            //    Console.WriteLine($"{lowerRankEmployee.FirstName} {lowerRankEmployee.LastName}");
            //}
        }
    }
}