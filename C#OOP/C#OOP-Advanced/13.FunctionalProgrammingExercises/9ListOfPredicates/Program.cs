namespace _9ListOfPredicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int border = int.Parse(Console.ReadLine());

            var dividers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> filter = (n, d) => n % d == 0;

            SelectAndPrint(border, dividers, filter);
        }

        private static void SelectAndPrint(int border, int[] dividers, Func<int, int, bool> filter)
        {
            var result = new List<int>();
            for (int i = 1; i <= border; i++)
            {
                var hasPassed = true;
                foreach (var divider in dividers)
                {
                    if (!filter(i, divider))
                    {
                        hasPassed = false;
                        break;
                    }
                }

                if (hasPassed)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}