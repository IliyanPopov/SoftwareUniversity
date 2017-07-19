namespace OOPExamMinedCraft.Models.Models.Harvesters
{
    using System.Text;

    public class SonicHarvester : Harvester
    {
        private int _sonicFactor;

        public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id, oreOutput, energyRequirement)
        {
            this.SonicFactor = sonicFactor;
            this.EnergyRequirement = this.EnergyRequirement / sonicFactor;
        }

        public int SonicFactor
        {
            get { return this._sonicFactor; }
            private set { this._sonicFactor = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sonic Harvester - {this.Id} ");
            sb.AppendLine($"Ore Output: {this.OreOutput} ");
            sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

            return sb.ToString().Trim();
        }
    }
}