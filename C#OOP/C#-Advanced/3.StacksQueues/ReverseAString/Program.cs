namespace ReverseAString
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> words = new Stack<char>();

            foreach (char t in input)
            {
                words.Push(t);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(words.Pop());
            }
            Console.WriteLine();
        }
    }
}