namespace InfernoInfinity.Client.Core
{
    using System;
    using System.Collections.Generic;
    using Commands;
    using Contracts;
    using Data.Repositories;
    using Models.Factories;

    public class CommandInterpreter
    {
        private readonly WeaponFactory _weaponFactory;
        private readonly IWriter _writer;
        private readonly InfernoInMemoryRepository _repository;

        public CommandInterpreter(InfernoInMemoryRepository repository, IWriter writer, WeaponFactory weaponFactory)
        {
            this._repository = repository;
            this._writer = writer;
            this.IsRunning = true;
            this._weaponFactory = weaponFactory;
        }

        public bool IsRunning { get; private set; }

        public void InterpredCommand(string input)
        {
            var data = input.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
            string commandName = data[0];

            try
            {
                Command command = ParseCommand(commandName, data);
                command.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private Command ParseCommand(string command, IList<string> data)
        {
            switch (command)
            {
                case "Create":
                    return new CreateCommand(data, this._repository, this._weaponFactory);
                case "Add":
                    return new AddCommand(data, this._repository);
                case "Remove":
                    return new RemoveCommand(data, this._repository);
                case "Print":
                    return new PrintCommand(data, this._writer, this._repository);
                case "Author":
                    return new AuthorCommand(data, this._writer);
                case "Description":
                    return new DescriptionCommand(data, this._writer);
                case "Revision":
                    return new RevisionCommand(data, this._writer);
                case "Reviewers":
                    return new ReviewersCommand(data, this._writer);
                case "END":
                    this.IsRunning = false;
                    return new EndCommand(data, this._writer);
                default:
                    throw new NotImplementedException("Command not Implemented!");
            }
        }
    }
}