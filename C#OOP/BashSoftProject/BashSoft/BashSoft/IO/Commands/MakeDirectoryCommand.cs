namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;
    using Contracts;
    using Contracts.Judge;
    using Contracts.Repository;
    using Exceptions;

    public class MakeDirectoryCommand : Command, IExecutable
    {
        public MakeDirectoryCommand(string input, List<string> data, IContentComparer judge, IDatabase repository,
            IDirecoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Count != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string folderName = this.Data[1];
            this.InputOutputManager.CreateDirectoryInCurrentFolder(folderName);
        }
    }
}