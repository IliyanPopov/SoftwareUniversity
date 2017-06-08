namespace _3PeriodicTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            HashSet<string> compoundsSet = new HashSet<string>();

            for (long i = 0; i < n; i++)
            {
                string[] compounds = Console.ReadLine().Split(' ').ToArray();
                for (long j = 0; j < compounds.Length; j++)
                {
                    if (compoundsSet.Contains(compounds[j]))
                    {
                        continue;
                    }
                    compoundsSet.Add(compounds[j]);
                }
            }

            foreach (var compound in compoundsSet.OrderBy(x =>x))
            {
                Console.Write($"{compound} ");
            }

            Console.WriteLine();
        }
    }
}