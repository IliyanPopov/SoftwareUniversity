namespace _14LettersChangeNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"([a-zA-Z])(\d+)([a-zA-Z])";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            double sum = 0;

            foreach (Match match in matches)
            {
                char firstChar = Convert.ToChar(match.Groups[1].ToString());
                long number = long.Parse(match.Groups[2].ToString());
                char lastChar = Convert.ToChar(match.Groups[3].ToString());

                int firstCharIndex = GetPositionInAlphabet(firstChar);
                int lastCharIndex = GetPositionInAlphabet(lastChar);

                if (char.IsUpper(firstChar))
                {
                    sum += (double) number / firstCharIndex;
                }
                else
                {
                    sum += number * firstCharIndex;
                }


                if (char.IsUpper(lastChar))
                {
                    sum -= lastCharIndex;
                }
                else
                {
                    sum += lastCharIndex;
                }
            }

            Console.WriteLine($"{sum:F2}");
        }

        private static int GetPositionInAlphabet(char character)
        {
            int index = char.ToUpper(character) - 64;

            return index;
        }
    }
}