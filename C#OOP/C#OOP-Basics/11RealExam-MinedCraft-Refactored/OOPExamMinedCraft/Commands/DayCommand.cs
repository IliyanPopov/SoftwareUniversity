namespace OOPExamMinedCraft.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Common.Utilities;
    using Core;
    using Minedcraft.Data;

    public class DayCommand : Command
    {
        public DayCommand(MinedraftRepository minedraftRepository, List<string> data, OutputWriter outputWriter) : base(
            minedraftRepository, data, outputWriter)
        {
        }

        public override void Execute()
        {
            double oresMined = 0;
            double energySoredInProviders = this.MinedraftRepository.Providers.Sum(p => p.EnergyOutput);
            double energyStoredInHarvesters = this.CalculateEnergyStoredInHarvestersDependingOnMode();
            this.MinedraftRepository.TotalEnergySoredInProviders += energySoredInProviders;
            bool isEnergyEnoughToStartMining = energyStoredInHarvesters <=
                                               this.MinedraftRepository.TotalEnergySoredInProviders;

            if (isEnergyEnoughToStartMining)
            {
                oresMined = this.MineOres();
                this.MinedraftRepository.TotalMinedOre += oresMined;
            }

            string dayRepresentation = this.DayRepresentation(energySoredInProviders, oresMined);
            this.OutputWriter.WriteMessageOnNewLine(dayRepresentation);
        }

        private string DayRepresentation(double energySoredInProviders, double oresMined)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A day has passed.");
            sb.AppendLine($"Energy Provided: {energySoredInProviders}");
            sb.AppendLine($"Plumbus Ore Mined: {oresMined}");

            return sb.ToString().Trim();
        }

        private double CalculateEnergyStoredInHarvestersDependingOnMode()
        {
            double energyStoredInHarvesters = 0;
            foreach (var harvester in this.MinedraftRepository.Harvesters)
            {
                switch (this.MinedraftRepository.CurrentMode)
                {
                    case "Full":
                        energyStoredInHarvesters += harvester.EnergyRequirement *
                                                    Constants.FullModeHarvesterEnergyRequirementMultiplyer;
                        break;
                    case "Half":
                        energyStoredInHarvesters += harvester.EnergyRequirement *
                                                     Constants.HalfModeHarvesterEnergyRequirementMultiplyer;
                        break;
                    case "Energy":
                        energyStoredInHarvesters += harvester.EnergyRequirement *
                                                    Constants.EnergyModeHarvesterEnergyRequirementMultiplyer;
                        break;
                }
            }

            return energyStoredInHarvesters;
        }

        private double MineOres()
        {
            double ores = 0;
            foreach (var harvester in this.MinedraftRepository.Harvesters)
            {
                switch (this.MinedraftRepository.CurrentMode)
                {
                    case "Full":
                        this.MinedraftRepository.TotalEnergySoredInProviders -=
                            harvester.EnergyRequirement * Constants.FullModeHarvesterEnergyRequirementMultiplyer;
                        ores += harvester.OreOutput * Constants.FullModeHarvesterOreOutputMultiplyer;
                        break;
                    case "Half":
                        this.MinedraftRepository.TotalEnergySoredInProviders -=
                            harvester.EnergyRequirement * Constants.HalfModeHarvesterEnergyRequirementMultiplyer;
                        ores += harvester.OreOutput * Constants.HalfModeHarvesterOreOutputMultiplyer;
                        break;
                    case "Energy":
                        this.MinedraftRepository.TotalEnergySoredInProviders -=
                            Constants.EnergyModeHarvesterEnergyRequirementMultiplyer;
                        ores += harvester.OreOutput * Constants.EnergyModeHarvesterOreOutputMultiplyer;
                        break;
                    default:
                        throw new NotImplementedException("Mode is not supported!");
                }
            }

            return ores;
        }
    }
}