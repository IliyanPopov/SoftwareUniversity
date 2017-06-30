namespace ReverseNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == null)
            {
                Environment.Exit(0);
            }

            decimal[] numbers = input
                .Trim()
                .Split(' ')
                .Select(x => decimal.Parse(x))
                .ToArray();

            Stack<decimal> numbersStack = new Stack<decimal>();


            for (int i = 0; i < numbers.Length; i++)
            {
                numbersStack.Push(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbersStack.Pop()} ");
            }
            Console.WriteLine();
        }
    }
}