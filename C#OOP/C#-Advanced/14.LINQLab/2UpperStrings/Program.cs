namespace _2UpperStrings
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            data.ForEach(w => Console.Write(w.ToUpper() + " "));
        }
    }
}