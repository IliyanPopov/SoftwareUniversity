namespace _10UseYourChains_Buddy
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string pattern = "<p>(.*?)<\\/p>";

            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            List<string> words = new List<string>();

            foreach (Match match in matches)
            {
                List<char> chars = new List<char>();
                var resultToDecrypt = match.Groups[1].Value;

                for (int i = 0; i < resultToDecrypt.Length; i++)
                {
                    if (!(char.IsLower(resultToDecrypt[i]) || char.IsDigit(resultToDecrypt[i])))
                    {
                        chars.Add(' ');
                    }
                    else
                    {
                        if (char.IsLetter(resultToDecrypt[i]))
                        {
                            if (resultToDecrypt[i] >= 97 && resultToDecrypt[i] < 110)
                            {
                                chars.Add((char)(resultToDecrypt[i] + 13));
                            }
                            else
                            {
                                chars.Add((char)(resultToDecrypt[i] - 13));
                            }
                        }
                        else
                        {
                            chars.Add(resultToDecrypt[i]);
                        }
                    }
                }
                string tempString = string.Join("", chars);
                var replacedText = Regex.Replace(tempString, @"\s+", " ");
                words.Add(replacedText);
            }

            foreach (var word in words)
            {
                Console.Write(word);
            }
            Console.WriteLine();

            //foreach (var word in words)
            //{
            //    for (int i = 0; i < word.Length; i++)
            //    {
            //        if (!(char.IsLower(word[i]) || char.IsDigit(word[i])))
            //        {
            //            word[i] = " ";
            //        }
            //    }   
            //}
        }
    }
}