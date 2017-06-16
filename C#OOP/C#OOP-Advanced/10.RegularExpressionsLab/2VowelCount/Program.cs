namespace _2VowelCount
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            string pattern = "[AEIOUYaeiouy]";

            Regex regex = new Regex(pattern);

            int coutnerVowels = regex.Matches(text).Count;

            Console.WriteLine($"Vowels: {coutnerVowels}");
        }
    }
}