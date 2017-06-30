namespace MatchingBrackets
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    for (int j = stack.Pop(); j <= i; j++)
                    {
                        Console.Write($"{input[j]}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}