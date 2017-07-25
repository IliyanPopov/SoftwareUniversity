namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;
    using Contracts;
    using Contracts.Judge;
    using Contracts.Repository;

    public class DropDatabaseCommand : Command, IExecutable
    {
        public DropDatabaseCommand(string input, List<string> data, IContentComparer judge, IDatabase repository, IDirecoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {

            if (this.Data.Count != 1)
            {
                this.DisplayInvalidCommandMessage(this.Input);
                return;
            }
            this.Repository.UnloadData();
            OutputWriter.WriteMessageOnNewLine("Database dropped!");
        }
    }
}
