namespace _6CountSubstringOccurrences
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string searchString = Console.ReadLine().ToLower();
            int counter = 0;
            if (text.Contains(searchString))
            {
                int startIndex = text.IndexOf(searchString);
                while (startIndex < text.Length)
                {
                    if (text.Contains(searchString))
                    {
                        counter++;
                    }
                    text = text.Substring(startIndex + 1, text.Length - startIndex - 1);

                    if (text.Contains(searchString))
                    {
                        startIndex = text.IndexOf(searchString);
                    }
                }
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine(counter);
            }
        }
    }
}