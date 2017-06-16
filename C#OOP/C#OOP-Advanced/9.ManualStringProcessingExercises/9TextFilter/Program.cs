namespace _9TextFilter
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string text = Console.ReadLine();

            foreach (string bannedWord in bannedWords)
            {
                if (text.Contains(bannedWord))
                {
                    int startIndex = text.IndexOf(bannedWord);
                    while (startIndex != -1)
                    {
                        int endIndex = startIndex + bannedWord.Length;
                        if (endIndex == -1)
                            break;
                        string astericsText = text.Substring(startIndex, endIndex - startIndex);
                        string replaceUpcase =
                            astericsText.Replace(bannedWord, new string('*', bannedWord.Length));
                        text = text.Replace(astericsText, replaceUpcase);
                        startIndex = text.IndexOf(bannedWord);
                    }
                }
            }

            Console.WriteLine(text);
        }
    }
}