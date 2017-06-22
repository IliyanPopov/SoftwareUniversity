namespace BashSoft
{
    using System;

    public class InputReader
    {
        private const string endCommand = "quit";
        public static void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.CurrentPath}> ");
            string input = Console.ReadLine();
            input = input.Trim();

            while (input != endCommand)
            {
                CommandInterpreter.InterpredCommand(input);
                OutputWriter.WriteMessage($"{SessionData.CurrentPath}> ");
                input = Console.ReadLine();
                input = input.Trim();
            }
        }
    }

}