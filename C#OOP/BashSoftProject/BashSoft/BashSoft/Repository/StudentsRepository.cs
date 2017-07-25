namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Contracts;
    using Contracts.Repository;
    using Models;

    public class StudentsRepository : IDatabase
    {
        private readonly IDataFilter filter;
        private readonly IDataSorter sorter;
        private Dictionary<string, ICourse> courses;
        private bool isDataInitialized;
        private Dictionary<string, IStudent> students;

        private Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

        public StudentsRepository(IDataSorter sorter, IDataFilter filter)
        {
            this.sorter = sorter;
            this.filter = filter;
            this.studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
        }

        public void LoadData(string fileName)
        {
            if (this.isDataInitialized)
            {
                throw new ArgumentException(ExceptionMessages.DataIsAlreadyInitialized);
            }

            OutputWriter.WriteMessageOnNewLine("Reading data...");
            this.students = new Dictionary<string, IStudent>();
            this.courses = new Dictionary<string, ICourse>();
            ReadData(fileName);
        }

        public void UnloadData()
        {
            if (!this.isDataInitialized)
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            this.studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
            this.students = null;
            this.courses = null;
            this.isDataInitialized = false;
        }

        public void GetStudentScoresFromCouse(string courseName, string username)
        {
            if (IsQueryForStudentPossible(courseName, username))
            {
                OutputWriter.PrintStudent(
                    new KeyValuePair<string, double>(username,
                        this.courses[courseName].StudentsByName[username].MarksByCourseName[courseName]));
            }
        }

        public void GetAllStudentFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}");

                foreach (var student in this.courses[courseName].StudentsByName)
                {
                    GetStudentScoresFromCouse(courseName, student.Key);
                }
            }
        }

        private void ReadData(string fileName)
        {
            string path = SessionData.CurrentPath + "\\" + fileName;
            string pattern = @"([A-Z][a-zA-Z#\++]*_[A-Z][a-z]{2}_\d{4})\s+([A-Za-z]+\d{2}_\d{2,4})\s([\s0-9]+)";
            Regex regex = new Regex(pattern);

            if (File.Exists(path))
            {
                string[] allInputLines = File.ReadAllLines(path);

                for (int line = 0; line < allInputLines.Length; line++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[line]) && regex.IsMatch(allInputLines[line]))
                    {
                        Match currenMatch = regex.Match(allInputLines[line]);

                        string courseName = currenMatch.Groups[1].Value;
                        string studentName = currenMatch.Groups[2].Value;
                        string scoresStr = currenMatch.Groups[3].Value;
                        try
                        {
                            int[] scores = scoresStr.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

                            if (scores.Any(x => x > 100 || x < 0))
                            {
                                OutputWriter.DisplayException(string.Join(ExceptionMessages.InvalidScore, 0, 1));
                                continue;
                            }

                            if (scores.Length > SoftUniCourse.NumberOfTasksOnExam)
                            {
                                OutputWriter.DisplayException(ExceptionMessages.InvalidNumberOfScores);
                                continue;
                            }

                            if (!this.students.ContainsKey(studentName))
                            {
                                this.students.Add(studentName, new SoftUniStudent(studentName));
                            }

                            if (!this.courses.ContainsKey(courseName))
                            {
                                this.courses.Add(courseName, new SoftUniCourse(courseName));
                            }

                            ICourse course = this.courses[courseName];
                            IStudent student = this.students[studentName];

                            student.EnrollInCourse(course);
                            student.SetMarksOnCourse(courseName, scores);

                            course.EnrollStudent(student);
                        }
                        catch (Exception fx)
                        {
                            OutputWriter.DisplayException(fx.Message + $"at line : {line}");
                        }
                    }
                }
                this.isDataInitialized = true;
                OutputWriter.WriteMessageOnNewLine("Data read!");
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
            }
        }

        private bool IsQueryForCoursePossible(string courseName)
        {
            if (this.isDataInitialized)
            {
                if (this.courses.ContainsKey(courseName))
                {
                    return true;
                }
                OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }


            return false;
        }

        private bool IsQueryForStudentPossible(string courseName, string studentName)
        {
            if (IsQueryForCoursePossible(courseName) &&
                this.courses[courseName].StudentsByName.ContainsKey(studentName))
            {
                return true;
            }
            OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);

            return false;
        }

        public void FilterAndTake(string courseName, string givenFIlter, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.courses[courseName].StudentsByName.Count;
                }

                Dictionary<string, double> marks = this.courses[courseName].StudentsByName
                    .ToDictionary(x => x.Key, x => x.Value.MarksByCourseName[courseName]);


                this.filter.FilterAndTake(marks, givenFIlter, studentsToTake.Value);
            }
        }

        public void OrderAndTake(string courseName, string comparison, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.courses[courseName].StudentsByName.Count;
                }

                Dictionary<string, double> marks = this.courses[courseName].StudentsByName
                    .ToDictionary(x => x.Key, x => x.Value.MarksByCourseName[courseName]);

                this.sorter.OrderAndTake(marks, comparison, studentsToTake.Value);
            }
        }
    }
}