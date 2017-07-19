namespace OOPExamMinedCraft.Core
{
    using System;
    using Common.Utilities;
    using Minedcraft.Data;

    public class Engine
    {
        private readonly CommandInterpreter _commandInterpreter;
        private MinedraftRepository _minedraftRepository;
        private OutputWriter _outputWriter;

        public Engine(MinedraftRepository minedraftRepository, OutputWriter outputWriter)
        {
            this._minedraftRepository = minedraftRepository;
            this._outputWriter = outputWriter;
            this._commandInterpreter = new CommandInterpreter(this._minedraftRepository, this._outputWriter);
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (this._commandInterpreter.IsRunning)
            {
                this._commandInterpreter.InterpredCommand(input);

                if (this._commandInterpreter.IsRunning)
                {
                    input = Console.ReadLine();
                }
            }
        }
    }
}