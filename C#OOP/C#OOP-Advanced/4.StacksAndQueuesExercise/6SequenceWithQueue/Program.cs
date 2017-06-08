namespace _6SequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            Queue<decimal> queue = new Queue<decimal>();

            queue.Enqueue(n);

            for (int i = 0; i < 50; i++)
            {
                decimal current = queue.Dequeue();

                Console.Write($"{current} ");
                decimal s2 = current + 1;
                decimal s3 = (2 * current) + 1;
                decimal s4 = current + 2;

                queue.Enqueue(s2);
                queue.Enqueue(s3);
                queue.Enqueue(s4);
            }
        }
    }
}