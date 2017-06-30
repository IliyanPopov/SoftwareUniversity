namespace _3FirstName
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var startingLetters = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string name = String.Empty;
            foreach (var letter in startingLetters.OrderBy(x => x))
            {
                name = names.Where(w => w.ToLower()
                    .StartsWith(letter.ToLower()))
                    .FirstOrDefault();
                if (name != null)
                {
                    Console.WriteLine(name);
                    break;
                }
            }
            if (name == null)
            {
                Console.WriteLine("No match");
            }
        }
    }
}