namespace BashSoft.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class CourseNotFoundException : Exception
    {
        private const string NotEnrolledInCourse = "Student {0} must be enrolled in a course before you set his mark.";
        public CourseNotFoundException()
        {
        }

        public CourseNotFoundException(string studentName) : base(string.Format(NotEnrolledInCourse, studentName))
        {
        }
    }
}