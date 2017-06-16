namespace _9QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Queue<string>();

            while (input != "END")
            {
                var tokens = input.Split('&').ToArray();
                var fieldValue = new Dictionary<string, List<string>>();
                foreach (var token in tokens)
                {
                    var separated = token.Split('=').ToArray();
                    if (separated.Length >= 2)
                    {
                        var fieldQuery = Regex.Match(token, @"(.+\?)*(\+|%20)*(.+?)(\+|%20)*=.*");
                        var field = fieldQuery.Groups[3].Value;
                        field = Regex.Replace(field, @"\+|%20", " ").Trim();
                        var valueQuery = separated[1];
                        valueQuery = Regex.Replace(valueQuery, @"\+|%20", " ").Trim();
                        var value = valueQuery.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                        if (!fieldValue.ContainsKey(field))
                        {
                            fieldValue[field] = new List<string>();
                        }

                        fieldValue[field].Add(string.Join(" ", value));
                    }
                }
                var sb = new StringBuilder();

                foreach (var kvp in fieldValue)
                {
                    sb.Append($"{kvp.Key}=[{string.Join(", ", kvp.Value)}]");
                }

                result.Enqueue(sb.ToString());

                input = Console.ReadLine();
            }

            while (result.Count > 0)
            {
                Console.WriteLine(result.Dequeue());
            }
        }
    }
}