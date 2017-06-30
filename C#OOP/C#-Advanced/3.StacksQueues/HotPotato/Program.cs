namespace HotPotato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int counter = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(names);
            while (queue.Count != 1)
            {
                for (int i = 1; i < counter; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }    
    }
}