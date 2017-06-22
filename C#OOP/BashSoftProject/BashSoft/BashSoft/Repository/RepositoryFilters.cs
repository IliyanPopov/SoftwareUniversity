namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class RepositoryFilters
    {
        public static void FilterAndTake(Dictionary<string, List<int>> wantedData, string wantedFilter,
            int studentsToTake)
        {
            wantedFilter = wantedFilter.ToLower();

            if (wantedFilter == "excellent")
            {
                FilterAndTake(wantedData, x => x >= 5, studentsToTake);
            }
            else if (wantedFilter == "average")
            {
                FilterAndTake(wantedData, x => 3.5 <= x && x < 5, studentsToTake);
            }
            else if (wantedFilter == "poor")
            {
                FilterAndTake(wantedData, x => x < 3.5, studentsToTake);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidStudentsFilter);
            }
        }

        private static void FilterAndTake(Dictionary<string, List<int>> wantedData, Predicate<double> givenFilter,
            int studentsToTake)
        {
            int counterForPrinted = 0;

            foreach (var username_Points in wantedData)
            {
                if (counterForPrinted == studentsToTake)
                {
                    break;
                }

                double averageScore = username_Points.Value.Average();
                double percentageOfFullFilment = averageScore / 100;
                double mark = percentageOfFullFilment * 4 + 2;

                if (givenFilter(mark))
                {
                    OutputWriter.PrintStudent(username_Points);
                    counterForPrinted++;
                }
            }
        }

        private static double Average(List<int> scoresOnTask)
        {
            int totalScore = 0;
            foreach (var score in scoresOnTask)
            {
                totalScore += score;
            }

            double percentageOfAll = totalScore / (scoresOnTask.Count * 100.0);
            var mark = percentageOfAll * 4 + 2;

            return mark;
        }
    }
}