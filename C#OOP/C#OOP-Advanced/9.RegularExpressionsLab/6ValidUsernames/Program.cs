namespace _6ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"<.*?>";

            Regex regex = new Regex(@"^[\w\d-]{3,16}$");
            string input = Console.ReadLine();
            while (input != "END")
            {
                MatchCollection matches = regex.Matches(input);
                if (matches.Count > 0)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("invalid");

                input = Console.ReadLine();
            }
        }
    }
}