namespace _2SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            HashSet<int> hashSet1 = new HashSet<int>();
            HashSet<int> hashSet2 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                hashSet1.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                hashSet2.Add(number);
            }

            foreach (var num in hashSet1)
            {
                if (hashSet2.Contains(num))
                {
                    Console.Write($"{num} ");                    
                }
            }
            Console.WriteLine();
        }
    }
}