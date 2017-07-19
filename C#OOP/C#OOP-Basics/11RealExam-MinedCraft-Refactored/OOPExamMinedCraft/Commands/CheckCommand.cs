namespace OOPExamMinedCraft.Commands
{
    using System.Collections.Generic;
    using System.Linq;
    using Common.Utilities;
    using Core;
    using Minedcraft.Data;

    public class CheckCommand : Command
    {
        public CheckCommand(MinedraftRepository minedraftRepository, List<string> data, OutputWriter outputWriter) : base(minedraftRepository, data, outputWriter)
        {
        }

        public override void Execute()
        {
            string id = this.Arguments[0];
            var harvester = this.MinedraftRepository.Harvesters.FirstOrDefault(h => h.Id == id);
            var provider = this.MinedraftRepository.Providers.FirstOrDefault(p => p.Id == id);

            if (harvester != null)
            {
                this.OutputWriter.WriteMessageOnNewLine(harvester.ToString());
            }

            if (provider != null)
            {
                this.OutputWriter.WriteMessageOnNewLine(provider.ToString());
            }

            this.OutputWriter.WriteMessageOnNewLine($"No element found with id - {id}");
        }
    }
}