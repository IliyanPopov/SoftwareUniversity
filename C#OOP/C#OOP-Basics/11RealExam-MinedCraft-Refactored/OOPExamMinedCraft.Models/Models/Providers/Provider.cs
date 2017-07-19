namespace OOPExamMinedCraft.Models.Models.Providers
{
    using System;
    using Common.Utilities;

    public abstract class Provider : Alien
    {
        private double _energyOutput;


        protected Provider(string id, double energyOutput)
            : base(id)
        {
            this.EnergyOutput = energyOutput;
        }


        public double EnergyOutput
        {
            get { return this._energyOutput; }
            protected set
            {
                if (value < Constants.MinProviderEnergyOutput || value > Constants.MaxProviderEnergyOutput)
                {
                    throw new ArgumentException(
                        $"Provider is not registered, because of it's {nameof(this.EnergyOutput)}");
                }
                this._energyOutput = value;
            }
        }

        public abstract double GetEnery();
    }
}