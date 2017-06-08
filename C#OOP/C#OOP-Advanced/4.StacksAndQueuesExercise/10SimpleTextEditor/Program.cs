namespace _10SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] operation = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                if (int.Parse(operation[0]) == 1)
                {
                    string textToAppend = operation[1];
                    if (stack.Count > 0)
                    {
                        stack.Push(stack.Peek() + textToAppend);
                    }
                    else
                    {
                        stack.Push(textToAppend);
                    }
                }
                else if (int.Parse(operation[0]) == 2)
                {
                    int countLettersToErase = int.Parse(operation[1]);
                    stack.Push(stack.Peek().Substring(0, stack.Peek().Length - countLettersToErase));
                }

                else if (int.Parse(operation[0]) == 3)
                {
                    int index = int.Parse(operation[1]) - 1;

                    var str = stack.Peek();

                    Console.WriteLine(str[index]);
                }

                else if (int.Parse(operation[0]) == 4)
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                    }
                }
            }
        }
    }
}