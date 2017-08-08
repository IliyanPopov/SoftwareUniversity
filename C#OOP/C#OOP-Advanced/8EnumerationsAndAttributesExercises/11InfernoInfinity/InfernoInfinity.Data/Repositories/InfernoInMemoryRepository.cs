namespace InfernoInfinity.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using Models.Contracts.Gems;
    using Models.Contracts.Weapons;
    using Models.Enumerations;
    using Models.Models;
    using Models.Models.Gems;

    public class InfernoInMemoryRepository
    {
        public InfernoInMemoryRepository()
        {
            this.Weapons = new List<IWeapon>();
            this.Gems = new List<IGem>();


            foreach (var gemClarityType in Enum.GetValues(typeof(GemClarityType)))
            {
                IGem amethyst = new Amethyst(gemClarityType.ToString());
                IGem emerald = new Emerald(gemClarityType.ToString());
                IGem ruby = new Ruby(gemClarityType.ToString());
                this.Gems.Add(amethyst);
                this.Gems.Add(emerald);
                this.Gems.Add(ruby);
            }
        }

        public IList<IWeapon> Weapons { get; }

        public IList<IGem> Gems { get; }
    }
}