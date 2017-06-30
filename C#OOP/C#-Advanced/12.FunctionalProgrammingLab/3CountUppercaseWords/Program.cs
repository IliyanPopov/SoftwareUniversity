namespace _3CountUppercaseWords
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            var result = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x)
                .Where(checker);

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}