namespace _1MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"\b([A-Z]{1}[a-z]{1,}) ([A-Z]{1}[a-z]{1,})\b";

            Regex regex = new Regex(pattern);
            string line = Console.ReadLine();
            while (line != "end")
            {
                MatchCollection matches = regex.Matches(line);
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
                line = Console.ReadLine();
            }
        }
    }
}