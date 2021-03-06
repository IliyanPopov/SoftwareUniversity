﻿namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Contracts.Judge;
    using Contracts.Repository;
    using Exceptions;
    using IO.Commands;

    public class CommandInterpreter : IInterpreter
    {
        private readonly IDirecoryManager inputOutputManager;
        private readonly IContentComparer judge;
        private readonly IDatabase repository;

        public CommandInterpreter(IContentComparer judge, IDatabase repository, IDirecoryManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }


        public void InterpretCommand(string input)
        {
            List<string> data = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            string commandName = data[0].ToLower();

            try
            {
                IExecutable command = ParseCommand(input, commandName, data);
                command.Execute();
            }
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message);
            }
        }

        private IExecutable ParseCommand(string input, string command, List<string> data)
        {
            switch (command)
            {
                case "open":
                    return new OpenFIleCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "show":
                    return new ShowWantedDataCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "mkdir":
                    return new MakeDirectoryCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "ls":
                    return new TraverseFolderCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "cmp":
                    return new CompareFilesCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "cdrel":
                    return new ChangePathRelativelyCommand(input, data, this.judge, this.repository,
                        this.inputOutputManager);
                case "cdabs":
                    return new ChangePathAbsoluteCommand(input, data, this.judge, this.repository,
                        this.inputOutputManager);
                case "readdb":
                    return new ReadFromDataBaseCommand(input, data, this.judge, this.repository,
                        this.inputOutputManager);
                case "help":
                    return new GetHelpCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "filter":
                    return new PrintFilteredStudentsCommand(input, data, this.judge, this.repository,
                        this.inputOutputManager);
                case "order":
                    return new PrintOrderedStudentsCommand(input, data, this.judge, this.repository,
                        this.inputOutputManager);
                case "decorder":
                    //  TODO: implement after functionallity is completed
                    throw new NotImplementedException();
                case "download":
                    // TODO: implement after functionallity is completed
                    throw new NotImplementedException();
                case "downloadasynch":
                    //  TODO: implement after functionallity is completed
                    throw new NotImplementedException();
                case "dropdb":
                    return new DropDatabaseCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                default:
                    throw new InvalidCommandException(input);
            }
        }
    }
}