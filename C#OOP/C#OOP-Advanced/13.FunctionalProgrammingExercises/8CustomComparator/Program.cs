namespace _8CustomComparator
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {

            var data = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Array.Sort(data, (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }
                if (x > y)
                {
                    return 1;
                }
                if (x < y)
                {
                    return -1;
                }
                return 0;
            });

            Console.WriteLine(string.Join(" ", data));
        }
    }
}