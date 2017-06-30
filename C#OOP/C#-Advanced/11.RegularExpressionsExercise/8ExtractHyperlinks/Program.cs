namespace _8ExtractHyperlinks
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        private static string tagPattern = @"<a\b[^>]*(.*?)";

        public static void Main()
        {
            string line = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            while (line != "END")
            {
                sb.Append(line);

                line = Console.ReadLine();
            }

            string result = sb.ToString();

            var resultSet = GetMatches(result);

            foreach (var VARIABLE in resultSet)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        private static List<string> GetMatches(string source)
        {
            var matchesList = new List<string>();
            //get the collection that match the tag pattern
            MatchCollection matches = Regex.Matches(source, tagPattern);
            //add the text under the href attribute
            //to the list
            foreach (Match match in matches)
            {
                string val = match.Value.Trim();
                if (val.Contains("href=\""))
                {
                    int startIndex = val.IndexOf("href=\"");
                    int endIndex = val.IndexOf("\"");
                    string link = val.Substring(startIndex, endIndex - startIndex);
                    matchesList.Add(link);
                }
            }
            return matchesList;
        }

    }
}