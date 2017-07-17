namespace BashSoft
{
    using System;

    public class InputReader
    {
        private CommandInterpreter interpreter;

        public InputReader(CommandInterpreter interpreter)
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
                this.interpreter.InterpredCommand(input);
                OutputWriter.WriteMessage($"{SessionData.CurrentPath}> ");
                input = Console.ReadLine();
                input = input.Trim();
            }
        }
    }

}