namespace BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inputSecondLine = Console.ReadLine();

            if (input == null)
            {
                Environment.Exit(0);
            }

            decimal[] numbers = input
                .Trim()
                .Split(' ')
                .Select(x => decimal.Parse(x))
                .ToArray();

            decimal countPopElements = numbers[1];
            decimal checkThisElement = numbers[2];

            if (inputSecondLine != null)
            {
                decimal[] numbersToPush = inputSecondLine
                    .Trim()
                    .Split(' ')
                    .Select(x => decimal.Parse(x))
                    .ToArray();

                Stack<decimal> stack = new Stack<decimal>();

                for (int i = 0; i < numbersToPush.Length; i++)
                {
                    stack.Push(numbersToPush[i]);
                }


                for (int i = 0; i < countPopElements; i++)
                {
                    stack.Pop();
                }

                if (stack.Contains(checkThisElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
            }
        }
    }
}