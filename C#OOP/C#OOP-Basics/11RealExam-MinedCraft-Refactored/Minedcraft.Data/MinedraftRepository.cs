namespace Minedcraft.Data
{
    using System.Collections.Generic;
    using OOPExamMinedCraft.Models.Models.Harvesters;
    using OOPExamMinedCraft.Models.Models.Providers;

    public class MinedraftRepository
    {
        public MinedraftRepository()
        {
            this.Harvesters = new List<Harvester>();
            this.Providers = new List<Provider>();
            this.CurrentMode = "Full";
        }

        public double TotalEnergySoredInProviders { get; set; }

        public double TotalMinedOre { get; set; }

        public string CurrentMode { get; set; }

        public List<Provider> Providers { get; set; }

        public List<Harvester> Harvesters { get; set; }
    }
}