﻿namespace BashSoft
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using BashSoft.Models;
    using Contracts.Repository;

    public class RepositorySorter : IDataSorter
    {
        public void OrderAndTake(Dictionary<string, double> studentsWithMarks, string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();

            if (comparison == "ascending")
            {
                this.PrintStudents(studentsWithMarks.OrderBy(x => x.Value)
                     .Take(studentsToTake)
                     .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else if (comparison == "descending")
            {
                PrintStudents(studentsWithMarks.OrderByDescending(x => x.Value)
                    .Take(studentsToTake)
                    .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else
            {
                throw new InvalidFilterCriteriaException(ExceptionMessages.InvalidComparisonQuery);
            }
        }


        private void PrintStudents(Dictionary<string, double> studentsSorted)
        {
            foreach (var pair in studentsSorted)
            {
                OutputWriter.PrintStudent(pair);
            }
        }
    }
}