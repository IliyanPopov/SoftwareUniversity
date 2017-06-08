namespace RecursiveFibunacci
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(n));
        }

        //private static long Fibonacci(int n)
        //{
        //    if (n == 2)
        //    {
        //        return 1;
        //    }

        //    if (n == 1)
        //    {
        //        return 1;
        //    }

        //    else
        //    {
        //        return Fibonacci(n - 1) + Fibonacci(n - 2);
        //    }
        //}

       private static long Fibonacci(int n)
        {
            long fn = 0;
            long fn1 = 1;
            long fn2 = 1;
            for (int i = 2; i < n; i++)
            {
                fn = fn1 + fn2;
                fn2 = fn1;
                fn1 = fn;
            }
            return fn;
        }
    }
}