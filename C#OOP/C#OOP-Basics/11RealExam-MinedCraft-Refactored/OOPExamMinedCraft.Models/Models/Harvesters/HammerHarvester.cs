﻿namespace OOPExamMinedCraft.Models.Models.Harvesters
{
    using System.Text;
    using Common.Utilities;

    public class HammerHarvester : Harvester
    {
        public HammerHarvester(string id, double oreOutput, double energyRequirement) : base(id, oreOutput,
            energyRequirement)
        {
            this.OreOutput = oreOutput * Constants.InitialHammerHarvesterOreOutputMultipiyer;
            this.EnergyRequirement = energyRequirement * Constants.InitialHammerHarvesterEnergyRequirementMultipiyer;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hammer Harvester - {this.Id} ");
            sb.AppendLine($"Ore Output: {this.OreOutput} ");
            sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

            return sb.ToString().Trim();
        }
    }
}