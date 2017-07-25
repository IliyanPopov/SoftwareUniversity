namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;
    using Contracts;
    using Contracts.Judge;
    using Contracts.Repository;

    public class ChangePathRelativelyCommand : Command, IExecutable
    {
        public ChangePathRelativelyCommand(string input, List<string> data, IContentComparer judge, IDatabase repository, IDirecoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Count != 2)
            {
                this.DisplayInvalidCommandMessage(this.Input);
            }
            else
            {
                string relPath = this.Data[1];
                this.InputOutputManager.ChangeCurrentDirectoryRelative(relPath);
            }
        }
    }
}
