namespace _5ExtractEmail
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern =
                @"(?<=[\s])([a-z,A-Z])([A-z.\d-]+?)([A-Za-z])@([A-z][A-z-.]+)(\.)([A-z]+)";

            string line = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(line);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}