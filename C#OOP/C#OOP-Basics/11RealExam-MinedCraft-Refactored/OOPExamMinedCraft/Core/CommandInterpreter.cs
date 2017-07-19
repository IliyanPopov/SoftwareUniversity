namespace OOPExamMinedCraft.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Commands;
    using Common.Utilities;
    using Minedcraft.Data;

    public class CommandInterpreter
    {
        private readonly MinedraftRepository _minedraftRepository;
        private readonly OutputWriter _outputWriter;

        public CommandInterpreter(MinedraftRepository minedraftRepository, OutputWriter outputWriter)
        {
            this._minedraftRepository = minedraftRepository;
            this._outputWriter = outputWriter;
            this.IsRunning = true;
        }

        public bool IsRunning { get; private set; }

        public void InterpredCommand(string input)
        {
            List<string> data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string commandName = data[0];
            data.Remove(commandName);

            try
            {
                Command command = this.ParseCommand(commandName, data);
                command.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private Command ParseCommand(string command, List<string> data)
        {
            switch (command)
            {
                case "RegisterHarvester":
                    return new RegisterHarvesterCommand(this._minedraftRepository, data, this._outputWriter);
                case "RegisterProvider":
                    return new RegisterProviderCommand(this._minedraftRepository, data, this._outputWriter);
                case "Mode":
                    return new ModeCommand(this._minedraftRepository, data, this._outputWriter);
                case "Day":
                    return new DayCommand(this._minedraftRepository, data, this._outputWriter);
                case "Check":
                    return new CheckCommand(this._minedraftRepository, data, this._outputWriter);
                case "Shutdown":
                    this.IsRunning = false;
                    return new ShutdownCommand(this._minedraftRepository, data, this._outputWriter);
                default:
                    throw new NotImplementedException("Command not Implemented!");
            }
        }
    }
}