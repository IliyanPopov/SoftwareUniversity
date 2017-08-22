namespace InfernoInfinity.Client.Core.Commands
{
    using System.Collections.Generic;
    using Contracts;
    using Data.Repositories;
    using Models.Factories;

    public abstract class Command
    {
        protected Command(IList<string> data, IWriter outputWriter)
            : this(data)
        {
            this.OutputWriter = outputWriter;
        }

        protected Command(IList<string> data)
        {
            this.Data = data;
        }

        protected Command(IList<string> data, InfernoInMemoryRepository repository, WeaponFactory factory)
            : this(data)
        {
            this.Repository = repository;
            this.WeaponFactory = factory;
        }

        protected Command(IList<string> data, IWriter outputWriter, InfernoInMemoryRepository repository)
            : this(data)
        {
            this.Repository = repository;
            this.OutputWriter = outputWriter;
        }

        protected Command(IList<string> data, InfernoInMemoryRepository repository)
            : this(data)
        {
            this.Repository = repository;
        }

        protected IList<string> Data { get; set; }

        protected IWriter OutputWriter { get; }

        protected InfernoInMemoryRepository Repository { get; }

        protected WeaponFactory WeaponFactory { get; }

        public abstract void Execute();
    }
}