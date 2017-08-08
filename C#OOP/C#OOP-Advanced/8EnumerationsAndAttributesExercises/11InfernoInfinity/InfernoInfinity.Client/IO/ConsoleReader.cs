namespace InfernoInfinity.Client.IO
{
    using System;
    using Contracts;
    public class ConsoleReader : IReader
    {
        public int Read()
        {
            return Console.Read();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
