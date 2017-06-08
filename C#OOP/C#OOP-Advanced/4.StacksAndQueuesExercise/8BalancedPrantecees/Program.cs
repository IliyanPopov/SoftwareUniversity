namespace _8BalancedPrantecees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();

            Stack<char> stack = new Stack<char>();

            bool arePrantheseesBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '[':
                    case '(':
                    case '{':
                        stack.Push(input[i]);
                        break;

                    case '}':
                        if (!stack.Any())
                            arePrantheseesBalanced = false;

                        else if (stack.Pop() != '{')
                            arePrantheseesBalanced = false;
                        break;

                    case ')':
                        if (!stack.Any())
                            arePrantheseesBalanced = false;

                        else if (stack.Pop() != '(')
                            arePrantheseesBalanced = false;
                        break;

                    case ']':
                        if (!stack.Any())
                            arePrantheseesBalanced = false;

                        else if (stack.Pop() != '[')
                            arePrantheseesBalanced = false;
                        break;
                }

                if (!arePrantheseesBalanced)
                    break;
            }
            Console.WriteLine(arePrantheseesBalanced ? "YES" : "NO");
        }
    }
}