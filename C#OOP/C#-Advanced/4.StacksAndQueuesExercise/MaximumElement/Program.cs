namespace MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            decimal countLines = decimal.Parse(Console.ReadLine());

            Stack<decimal> stack = new Stack<decimal>();
            Stack<decimal> maxStack = new Stack<decimal>();
            decimal maxElement = int.MinValue;

            for (int i = 0; i < countLines; i++)
            {
                decimal[] input = Console.ReadLine()
                    .Split(' ')
                    .Select(decimal.Parse)
                    .ToArray();

                if (input.Length == 2)
                {
                    decimal numberToAdd = input[1];
                    if (maxElement < numberToAdd)
                    {
                        maxElement = numberToAdd;
                        maxStack.Push(maxElement);
                    }
                    stack.Push(numberToAdd);
                }
                else if (input[0] == 2 && stack.Peek() == maxStack.Peek() && stack.Count > 0)
                {
                    maxStack.Pop();
                    if (maxStack.Count > 0)
                    {
                        maxElement = maxStack.Peek();
                    }
                    else
                    {
                        maxElement = int.MinValue;
                    }
                    stack.Pop();
                }
                else if (input[0] == 3 && stack.Count > 0)
                {
                    Console.WriteLine(maxStack.Peek());
                }
            }
        }
    }
}