namespace OOPExamMinedCraft.Commands
{
    using System;
    using System.Collections.Generic;
    using Common.Utilities;
    using Core;
    using Minedcraft.Data;
    using Models.Factories;
    using Models.Models.Harvesters;

    public class RegisterHarvesterCommand : Command
    {
        private readonly HarvesterFactory _harvesterFactory;

        public RegisterHarvesterCommand(MinedraftRepository minedraftRepository, List<string> data, OutputWriter outputWriter)
            : base(minedraftRepository, data, outputWriter)
        {
            this._harvesterFactory = new HarvesterFactory();
        }

        public override void Execute()
        {
            string harvesterType = this.Arguments[0];
            string id = this.Arguments[1];

            try
            {
                Harvester harvester = this._harvesterFactory.CreateHarvester(this.Arguments);
                this.MinedraftRepository.Harvesters.Add(harvester);
                this.OutputWriter.WriteMessageOnNewLine($"Successfully registered {harvesterType} Harvester - {id}");
            }
            catch (Exception e)
            {
                this.OutputWriter.DisplayException(e.Message);
            }
        }
    }
}