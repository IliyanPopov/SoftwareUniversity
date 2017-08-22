namespace InfernoInfinity.Models.Contracts.Weapons
{
    using Enumerations;
    using Gems;
    using Models;

    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        IGem[] GemSockets { get; }

        RarityType RarityType { get; }

        string Print();
    }
}