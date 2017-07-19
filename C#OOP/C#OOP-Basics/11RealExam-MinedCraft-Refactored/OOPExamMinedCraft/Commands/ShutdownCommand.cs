namespace OOPExamMinedCraft.Commands
{
    using System.Collections.Generic;
    using System.Text;
    using Common.Utilities;
    using Minedcraft.Data;

    public class ShutdownCommand : Command
    {
        public ShutdownCommand(MinedraftRepository minedraftRepository, List<string> data, OutputWriter outputWriter) : base(minedraftRepository, data, outputWriter)
        {
        }

        public override void Execute()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("System Shutdown");
            sb.AppendLine($"Total Energy Stored: {this.MinedraftRepository.TotalEnergySoredInProviders}");
            sb.AppendLine($"Total Mined Plumbus Ore: {this.MinedraftRepository.TotalMinedOre}");

            this.OutputWriter.WriteMessageOnNewLine(sb.ToString().Trim());
        }
    }
}