namespace _4AcademyGraduation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            SortedDictionary<string, List<double>> namesAndScores = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                string scoresStr = Console.ReadLine();
                List<double> scores = scoresStr.Trim()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList();
                if (!namesAndScores.ContainsKey(name))
                {
                    namesAndScores.Add(name, scores);
                }
                else
                {
                    namesAndScores[name].AddRange(scores);
                }
            }

            foreach (var namesAndScore in namesAndScores)
            {
                Console.WriteLine($"{namesAndScore.Key} is graduated with {namesAndScore.Value.Average()}");
            }
        }
    }
}