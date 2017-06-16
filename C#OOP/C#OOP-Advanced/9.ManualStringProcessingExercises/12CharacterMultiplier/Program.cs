namespace _12CharacterMultiplier
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(new[] {' ',}, StringSplitOptions.RemoveEmptyEntries)
                .OrderByDescending(x => x.Length).ToArray();

            var word1 = words[0];
            var word2 = words[1];

            var sum = GetSumOfStringCharacters(word2, word1);
            Console.WriteLine(sum);
        }

        private static long GetSumOfStringCharacters(string word2, string word1)
        {
            long sum = 0;

            for (int i = 0; i < word2.Length; i++)
            {
                sum += word1[i] * word2[i];
            }

            if (word1.Length != word2.Length)
            {
                for (int i = word2.Length; i < word1.Length; i++)
                {
                    sum += word1[i];
                }
            }
            return sum;
        }
    }
}