namespace _3Non_DigitCount
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"\D";

            Regex regex = new Regex(pattern);
            int counterNonDigits = regex.Matches(text).Count;

            Console.WriteLine($"Non-digits: {counterNonDigits}");
        }
    }
}