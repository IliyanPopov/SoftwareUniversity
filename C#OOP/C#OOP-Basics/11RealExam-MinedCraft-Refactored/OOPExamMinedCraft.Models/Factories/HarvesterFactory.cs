namespace OOPExamMinedCraft.Models.Factories
{
    using System;
    using System.Collections.Generic;
    using Models.Harvesters;

    public class HarvesterFactory
    {
        public Harvester CreateHarvester(List<string> harvesterArgs)
        {
            string type = harvesterArgs[0];
            string id = harvesterArgs[1];
            double oreOutput = double.Parse(harvesterArgs[2]);
            double energyOutput = double.Parse(harvesterArgs[3]);

            switch (type)
            {
                case "Hammer":
                    return new HammerHarvester(id, oreOutput, energyOutput);
                case "Sonic":
                    int sonicFactor = int.Parse(harvesterArgs[4]);
                    return new SonicHarvester(id, oreOutput, energyOutput, sonicFactor);

                default:
                    throw new NotImplementedException();
            }
        }
    }
}

