namespace InfernoInfinity.Client.Core.Commands
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Data.Repositories;

    public class PrintCommand : Command
    {
        public PrintCommand(IList<string> data, IWriter outputWriter,
            InfernoInMemoryRepository repository)
            : base(data, outputWriter, repository)
        {
        }

        public override void Execute()
        {
            string weaponToPrintName = this.Data[1];
            var weaponPrintResult =
                this.Repository.Weapons.FirstOrDefault(w => w.Name == weaponToPrintName);
            this.OutputWriter.WriteLine(weaponPrintResult?.Print());
        }
    }
}