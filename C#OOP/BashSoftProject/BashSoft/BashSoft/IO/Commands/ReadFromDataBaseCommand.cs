namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;
    using Contracts;
    using Contracts.Judge;
    using Contracts.Repository;

    public class ReadFromDataBaseCommand : Command, IExecutable
    {
        public ReadFromDataBaseCommand(string input, List<string> data, IContentComparer judge, IDatabase repository, IDirecoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
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
                string fileName = this.Data[1];
                this.Repository.LoadData(fileName);
            }
        }
    }
}
