namespace _1ActionPrint
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Action<string> printer = s => Console.WriteLine(s);
            var result = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            result.ForEach(printer);
        }
    }
}