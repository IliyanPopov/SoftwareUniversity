namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using Contracts;
    using Contracts.Judge;
    using Contracts.Repository;
    using Exceptions;

    public class OpenFIleCommand : Command, IExecutable
    {
        public OpenFIleCommand(string input, List<string> data, IContentComparer judge, IDatabase repository, IDirecoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Count != 2)
            {
                throw new InvalidCommandException(this.Input);
            }
            string fileName = this.Data[1];
            Process.Start(SessionData.CurrentPath + "\\" + fileName);
        }
    }
}
