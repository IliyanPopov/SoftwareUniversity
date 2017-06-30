namespace SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int previousNumber = 0;
            int currentNumber = 0;
            int tempNumber;
            string operand = String.Empty;
            const string operators = "+-";

            Stack<string> stack = new Stack<string>();
            Stack<string> reversedStack = new Stack<string>();

            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            foreach (var str in input)
            {
                if (Int32.TryParse(str, out tempNumber))
                {
                    stack.Push(str);
                }
                else
                {
                    if (operators.Contains(str))
                    {
                        stack.Push(str);
                    }
                }
            }

            //reverse the stack
            while (stack.Count > 0)
            {
                reversedStack.Push(stack.Pop());
            }

            stack = reversedStack;

            previousNumber = int.Parse(stack.Pop().ToString());

            while (stack.Count > 0)
            {
                operand = stack.Pop().ToString();
                currentNumber = int.Parse(stack.Pop().ToString());

                previousNumber = Calculate(previousNumber, operand, currentNumber);
            }

            Console.WriteLine(previousNumber);
        }

        private static int Calculate(int previousNumber, string operand, int currentNumber)
        {
            int result = 0;

            switch (operand)
            {
                case "+":
                    result = previousNumber + currentNumber;
                    break;

                case "-":
                    result = previousNumber - currentNumber;
                    break;
            }

            return result;
        }
    }
}