namespace OOPExamMinedCraft.Models.Models.Providers
{
    using System.Text;
    using Common.Utilities;

    public class PressureProvider : Provider
    {
        public PressureProvider(string id, double energyOutput) : base(id, energyOutput)
        {
            this.EnergyOutput = energyOutput * Constants.InitialPressureProviderEneryOutputMultipliyer;
        }

        public override double GetEnery()
        {
            return this.EnergyOutput;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pressure Provider - {this.Id} ");
            sb.AppendLine($"Energy Output: {this.EnergyOutput}");

            return sb.ToString().Trim();
        }
    }
}