namespace OOPExamMinedCraft.Models.Factories
{
    using System;
    using System.Collections.Generic;
    using Models.Providers;

    public class ProviderFactory
    {
        public Provider CreateProvider(List<string> providerArgs)
        {
            string type = providerArgs[0];
            string id = providerArgs[1];
            double energyOutput = double.Parse(providerArgs[2]);

            switch (type)
            {
                case "Solar":
                    return new SolarProvider(id, energyOutput);
                case "Pressure":
                    return new PressureProvider(id, energyOutput);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

