namespace _2MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"\+359(-|\ )2\1\d{3}\1\d{4}\b";

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