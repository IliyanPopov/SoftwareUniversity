namespace InfernoInfinity.Models.Models.Weapons
{
    using Common.Utilities;

    public class Knife : Weapon
    {
        public Knife(string name, string rarityType)
            : this(name, Constants.KnifeMinDamage, Constants.KnifeMaxDamage, Constants.KnifeSocketsCount, rarityType)
        {
        }

        protected Knife(string name, int minDamage, int maxDamage, int socketsCount, string rarityType) : base(name,
            minDamage, maxDamage, socketsCount, rarityType)
        {
        }
    }
}