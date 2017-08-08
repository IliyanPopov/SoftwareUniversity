namespace InfernoInfinity.Models.Models.Weapons
{
    using Common.Utilities;

    public class Sword : Weapon
    {
        public Sword(string name, string rarityType)
            : base(name, Constants.SwordMinDamage, Constants.SwordMaxDamage, Constants.SwordSocketsCount, rarityType)
        {
        }
    }
}