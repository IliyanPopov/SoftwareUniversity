namespace OOPExamMinedCraft.Models.Models.Providers
{
    using System.Text;

    public class SolarProvider : Provider
    {
        public SolarProvider(string id, double energyOutput) : base(id, energyOutput)
        {
        }

        public override double GetEnery()
        {
            return this.EnergyOutput;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Solar Provider - {this.Id} ");
            sb.AppendLine($"Energy Output: {this.EnergyOutput}");

            return sb.ToString().Trim();
        }
    }
}

