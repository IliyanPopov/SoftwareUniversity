namespace _5AppliedArithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            string command = Console.ReadLine();
            var tempList = new List<double>();

            Action<double> doublePrinter = d => Console.Write(d + " ");
            while (command != "end")
            {
                switch (command)
                {
                    case "add":

                        tempList = numbers.Select(n => n + 1).ToList();
                        numbers.Clear();
                        numbers.AddRange(tempList);
                        tempList.Clear();
                        break;
                    case "subtract":

                        tempList = numbers.Select(n => n - 1).ToList();
                        numbers.Clear();
                        numbers.AddRange(tempList);
                        tempList.Clear();
                        break;
                    case "multiply":
                        tempList = numbers.Select(n => n * 2).ToList();
                        numbers.Clear();
                        numbers.AddRange(tempList);
                        tempList.Clear();
                        break;
                    case "print":
                        numbers.ForEach(doublePrinter);
                        Console.WriteLine();
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}