namespace _1MatchCount
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = Console.ReadLine();

            string text = Console.ReadLine();


            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            long coutner = 0;

            foreach (Match match in matches)
            {
                coutner++;
            }

            Console.WriteLine(coutner);
        }
    }
}