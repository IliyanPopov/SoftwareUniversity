namespace BashSoft.IO.Commands
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Contracts.Judge;
    using Contracts.Repository;
    using Exceptions;

    public abstract class Command : IExecutable
    {
        private List<string> _data;
        private string _input;
        private readonly IDirecoryManager _inputOutputManager;


        private readonly IContentComparer _judge;
        private readonly IDatabase _repository;

        protected Command(string input, List<string> data, IContentComparer judge, IDatabase repository,
                IDirecoryManager inputOutputManager)
        //    :this()
        {
            this.Input = input;
            this.Data = data;
            this._judge = judge;
            this._repository = repository;
            this._inputOutputManager = inputOutputManager;
        }

        public string Input
        {
            get { return this._input; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                this._input = value;
            }
        }

        public List<string> Data
        {
            get { return this._data; }
            private set
            {
                this._data = value;
            }
        }

        protected IContentComparer Judge
        {
            get { return this._judge; }
        }

        protected IDatabase Repository
        {
            get { return this._repository; }
        }

        protected IDirecoryManager InputOutputManager
        {
            get { return this._inputOutputManager; }
        }

        public abstract void Execute();

        protected virtual void DisplayInvalidCommandMessage(string input)
        {
            OutputWriter.DisplayException($"The command '{input}' is invalid");
        }
    }
}