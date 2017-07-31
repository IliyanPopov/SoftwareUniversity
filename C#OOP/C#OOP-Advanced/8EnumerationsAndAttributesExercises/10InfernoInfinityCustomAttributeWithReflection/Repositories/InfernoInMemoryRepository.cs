using System;
using System.Collections.Generic;
using System.Linq;

public class InfernoInMemoryRepository
{
    public InfernoInMemoryRepository()
    {
        this.Weapons = new List<IWeapon>();
        this.Gems = new List<IGem>();

        foreach (var gemType in Enum.GetValues(typeof(GemType)))
        {
            foreach (var gemClarityType in Enum.GetValues(typeof(GemClarityType)))
            {
                IGem gem = new Gem(gemClarityType.ToString(), gemType.ToString());
                this.Gems.Add(gem);
            }
        }
    }

    public IList<IWeapon> Weapons { get; }

    public IList<IGem> Gems { get; }

    public void AddWeapon(IWeapon weapon)
    {
        if (this.Weapons.All(w => w.Name != weapon.Name))
        {
            this.Weapons.Add(weapon);
        }
    }

    public void AddGem(IGem gem)
    {
        if (this.Gems.All(g => g.Type != gem.Type || g.ClarityType != gem.ClarityType))
        {
            this.Gems.Add(gem);
        }
    }
}