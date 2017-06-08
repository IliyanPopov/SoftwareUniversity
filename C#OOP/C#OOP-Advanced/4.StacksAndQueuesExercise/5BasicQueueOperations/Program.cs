using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5BasicQueueOperations
{
    class Program
    {
       public  static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inputSecondLine = Console.ReadLine();

            if (input == null)
            {
                Environment.Exit(0);
            }

            decimal[] numbers = input
                .Trim()
                .Split(' ')
                .Select(x => decimal.Parse(x))
                .ToArray();

            decimal countPopElements = numbers[1];
            decimal checkThisElement = numbers[2];

            if (inputSecondLine != null)
            {
                decimal[] numbersToPush = inputSecondLine
                    .Trim()
                    .Split(' ')
                    .Select(x => decimal.Parse(x))
                    .ToArray();

                Queue<decimal> queue = new Queue<decimal>();

                for (int i = 0; i < numbersToPush.Length; i++)
                {
                    queue.Enqueue(numbersToPush[i]);
                }


                for (int i = 0; i < countPopElements; i++)
                {
                    queue.Dequeue();
                }

                if (queue.Contains(checkThisElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    if (queue.Count != 0)
                    {
                        Console.WriteLine(queue.Min());
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
            }
        }
    }
}
