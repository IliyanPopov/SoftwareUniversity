public class Sword : Weapon
{
    public Sword(string name, string rarityType)
        : base(name, Constants.SwordMinDamage, Constants.SwordMaxDamage, Constants.SwordSocketsCount, rarityType)
    {
    }

    protected Sword(string name, int minDamage, int maxDamage, int socketsCount, string rarityType) : base(name,
        minDamage, maxDamage, socketsCount, rarityType)
    {
    }
}