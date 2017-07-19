namespace OOPExamMinedCraft.Commands
{
    using System;
    using System.Collections.Generic;
    using Common.Utilities;
    using Core;
    using Minedcraft.Data;

    public class ModeCommand : Command
    {
        public ModeCommand(MinedraftRepository minedraftRepository, List<string> data, OutputWriter outputWriter) : base(minedraftRepository, data, outputWriter)
        {
        }

        public override void Execute()
        {
            string mode = this.Arguments[0];
            this.MinedraftRepository.CurrentMode = mode;

            this.OutputWriter.WriteMessageOnNewLine($"Successfully changed working mode to {mode} Mode");
        }
    }
}