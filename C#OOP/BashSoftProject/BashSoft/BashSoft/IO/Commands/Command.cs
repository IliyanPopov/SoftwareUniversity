namespace BashSoft.IO.Commands
{
    using System;
    using System.Collections.Generic;
    using Exceptions;

    public abstract class Command
    {
        private List<string> _data;
        private string _input;
        private readonly IOManager _inputOutputManager;


        private readonly Tester _judge;
        private readonly StudentsRepository _repository;

        protected Command(string input, List<string> data, Tester judge, StudentsRepository repository,
            IOManager inputOutputManager)
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
          private  set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                this._input = value;
            }
        }

        //public Command()
        //{
        //    this.Data = new List<string>();
        //}

        public List<string> Data
        {
            get { return this._data; }
           private set
            {
                //if (value == null || this.Data.Count == 0)
                //{
                //    throw new NullReferenceException();
                //}

                this._data = value;
            }
        }

        protected Tester Judge
        {
            get { return this._judge; }
        }

        protected StudentsRepository Repository
        {
            get { return this._repository; }
        }

        protected IOManager InputOutputManager
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