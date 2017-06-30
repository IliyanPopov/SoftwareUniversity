namespace Dec2BinaryConverter
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Stack<decimal> numbers = new Stack<decimal>();

            if (input == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                while (input > 0)
                {
                    numbers.Push(input % 2);

                    input = input / 2;
                }

                foreach (var num in numbers)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}