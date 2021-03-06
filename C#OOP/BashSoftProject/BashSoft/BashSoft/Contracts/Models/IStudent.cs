﻿namespace BashSoft.Contracts
{
    using System.Collections.Generic;

    public interface IStudent
    {
        string UserName { get; }

        IReadOnlyDictionary<string, ICourse> EnrolledCourses { get; }

        IReadOnlyDictionary<string, double> MarksByCourseName { get; }

        void EnrollInCourse(ICourse course);

        void SetMarksOnCourse(string courseName, params int[] scores);
    }
}