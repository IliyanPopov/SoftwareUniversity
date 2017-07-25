namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;
    using Contracts;
    using Contracts.Judge;
    using Contracts.Repository;

    public class CompareFilesCommand : Command, IExecutable
    {
        public CompareFilesCommand(string input, List<string> data, IContentComparer judge, IDatabase repository, IDirecoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Count != 3)
            {
                this.DisplayInvalidCommandMessage(this.Input);
            }
            else
            {
                string firstPath = this.Data[1];
                string secondPath = this.Data[2];

                this.Judge.CompareContent(firstPath, secondPath);
            }
        }
    }
}
