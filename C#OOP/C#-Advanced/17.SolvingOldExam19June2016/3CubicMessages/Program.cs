namespace _3CubicMessages
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "Over!")
            {
                int n = int.Parse(Console.ReadLine());

                string pattern = $@"^((\d+)([a-zA-Z]{{{n}}})([^a-zA-Z]*))$";

                foreach (Match match in Regex.Matches(input, pattern))
                {
                    List<int> indexes = new List<int>();

                    var resultToDecrypt = match.Groups[3].Value;
                    string matchString = match.ToString();

                    foreach (var letter in matchString)
                    {
                        if (char.IsDigit(letter))
                        {
                            indexes.Add((int) (letter - '0'));
                        }
                    }

                    var decryptedMessage = DecryptMessage(indexes, resultToDecrypt);

                    Console.WriteLine($"{resultToDecrypt} == {decryptedMessage}");
                }
                input = Console.ReadLine();
            }
        }

        private static string DecryptMessage(List<int> indexes, string message)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var index in indexes)
            {
                if (index < message.Length)
                {
                    sb.Append(message[index]);
                }
                else
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}