namespace _6SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var keyword = Console.ReadLine().Trim();
            var text = Console.ReadLine().Trim();

            var regex = new Regex($@"[^.?!]*(?<=[.?\s!]){keyword}(?=[\s.?!])[^.?!]*[.?!]");

            var results = regex.Matches(text);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}