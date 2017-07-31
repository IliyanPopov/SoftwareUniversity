using System.Collections.Generic;

public interface IWeapon
{
    string Name { get; set; }

    int MinDamage { get; set; }

    int MaxDamage { get; set; }

    IGem[] GemSockets { get; set; }

    RarityType RarityType { get; set; }

    void AddGem(IGem gem, int index);

    void RemoveGem(int index);

    string Print();
}