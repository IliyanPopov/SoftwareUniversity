public class Axe : Weapon
{
    public Axe(string name, string rarityType)
        : this(name, Constants.AxeMinDamage, Constants.AxeMaxDamage, Constants.AxeSocketsCount, rarityType)
    {
    }

    protected Axe(string name, int minDamage, int maxDamage, int sockets, string rarityType) : base(name, minDamage,
        maxDamage, sockets,
        rarityType)
    {
    }
}