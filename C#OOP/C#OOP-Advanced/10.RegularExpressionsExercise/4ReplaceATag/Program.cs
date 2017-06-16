namespace _4ReplaceATag
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            //<a (href=".*?")>(.*?)<\/a>$
            string pattern = @"<a (href="".*?"")>(.*?)<\/a>";
            string line = Console.ReadLine().Trim();
            StringBuilder sb = new StringBuilder();

            while (line != "end")
            {
                sb.AppendLine(line);

                line = Console.ReadLine();
            }

            var resultText = sb.ToString();
            var replacedText = Regex.Replace(resultText, pattern, m => $"[URL {m.Groups[1]}]{m.Groups[2]}[/URL]");

            Console.WriteLine(replacedText);
        }
    }
}