namespace _10UnicodeCharacters
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var chars = input
                .Select(c => (int) c)
                .Select(c => $@"\u{c:x4}");

            var result = string.Concat(chars);

            Console.WriteLine(result);
        }
    }
}