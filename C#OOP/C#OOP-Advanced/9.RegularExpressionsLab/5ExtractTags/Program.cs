namespace _5ExtractTags
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"<.*?>";

            Regex regex = new Regex(pattern);
            string line = Console.ReadLine();
            while (line != "END")
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