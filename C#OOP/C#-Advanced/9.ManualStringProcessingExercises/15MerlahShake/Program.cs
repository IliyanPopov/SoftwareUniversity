namespace _15MerlahShake
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            var matches = Regex.Matches(text, Regex.Escape(pattern));

            while (true)
            {
                if (matches.Count >= 2 && pattern.Length > 0)
                {
                    var firstPattern = text.IndexOf(pattern);
                    var lastPattern = text.LastIndexOf(pattern);

                    text = text.Remove(lastPattern, pattern.Length);
                    text = text.Remove(firstPattern, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                matches = Regex.Matches(text, Regex.Escape(pattern));
            }

            Console.WriteLine(text);
        }
    }
}