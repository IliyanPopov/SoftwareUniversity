namespace BashSoft
{
    using System;
    using Contracts;

    public class InputReader : IReader
    {
        private readonly IInterpreter interpreter;

        public InputReader(IInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        private const string endCommand = "quit";

        public void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.CurrentPath}> ");
            string input = Console.ReadLine();
            input = input.Trim();

            while (input != endCommand)
            {
                this.interpreter.InterpretCommand(input);
                OutputWriter.WriteMessage($"{SessionData.CurrentPath}> ");
                input = Console.ReadLine();
                input = input.Trim();
            }
        }
    }

}