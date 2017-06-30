namespace _11Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            char[] decimilers = new[] {' ', ',', '.', '?', '!'};

            string[] possiblePalindromes = Console.ReadLine()
                .Split(decimilers, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (var word in possiblePalindromes)
            {
                bool isPalindrome = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == word[word.Length - 1 - i])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                    }
                }
                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine($"[{string.Join(", ", palindromes.Distinct().OrderBy(x => x))}]");
        }
    }
}