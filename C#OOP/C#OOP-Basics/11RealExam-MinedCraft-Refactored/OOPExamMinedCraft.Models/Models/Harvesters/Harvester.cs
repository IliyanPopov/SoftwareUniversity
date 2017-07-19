namespace OOPExamMinedCraft.Models.Models.Harvesters
{
    using System;
    using Common.Utilities;

    public abstract class Harvester : Alien
    {
        private double _energyRequirement;
        private double _oreOutput;

        protected Harvester(string id, double oreOutput, double energyRequirement)
            : base(id)
        {
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyRequirement;
        }


        public double OreOutput
        {
            get { return this._oreOutput; }
            set
            {
                if (value < Constants.MinHarvesterOreOutput)
                {
                    throw new ArgumentException(
                        $"Harvester is not registered, because of it's {nameof(this.OreOutput)}");
                }
                this._oreOutput = value;
            }
        }

        public double EnergyRequirement
        {
            get { return this._energyRequirement; }
            set
            {
                if (value < Constants.MinHarvesterEnergyOutput || (value > Constants.MaxHarvesterEnergyOutput))
                {
                    throw new ArgumentException(
                        $"Harvester is not registered, because of it's {nameof(this.EnergyRequirement)}");
                }
                this._energyRequirement = value;
            }
        }
    }
}