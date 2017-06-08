namespace Test
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcd";
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);
            }

            stack.Push(stack.Pop());
            stack.Push(stack.Pop());
            stack.Push(stack.Pop());
        }
    }
}