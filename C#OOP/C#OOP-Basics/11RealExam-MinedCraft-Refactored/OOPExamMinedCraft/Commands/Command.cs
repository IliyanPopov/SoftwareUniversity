namespace OOPExamMinedCraft.Commands
{
    using System.Collections.Generic;
    using Common.Utilities;
    using Core;
    using Minedcraft.Data;

    public abstract class Command
    {
        protected Command(MinedraftRepository minedraftRepository, List<string> data, OutputWriter outputWriter)
        {
            this.MinedraftRepository = minedraftRepository;
            this.Arguments = data;
            this.OutputWriter = outputWriter;
        }

        protected List<string> Arguments { get; set; }

        protected MinedraftRepository MinedraftRepository { get; set; }

        protected OutputWriter OutputWriter { get; }

        public abstract void Execute();
    }
}