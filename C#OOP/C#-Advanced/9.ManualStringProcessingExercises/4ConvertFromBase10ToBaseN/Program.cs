namespace _4ConvertFromBase10ToBaseN
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            string[] data = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int n = int.Parse(data[0]);
            BigInteger number = BigInteger.Parse(data[1]);

            string result = null;

            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    var reminder = number % n;
                    number /= n;

                    result = reminder.ToString() + result;
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}