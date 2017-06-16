namespace _3SeriesOfLetters
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"([a-zA-Z])(\1+)";

            string text = Console.ReadLine();

            var result = Regex.Replace(text, pattern, "$1");
            Console.WriteLine(result);
        }
    }
}