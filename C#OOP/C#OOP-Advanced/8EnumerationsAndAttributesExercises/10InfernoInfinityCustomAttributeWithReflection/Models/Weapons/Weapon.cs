using System;
using System.Linq;
using System.Text;

[Description("Pesho",3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
public abstract class Weapon : IWeapon
{
    private RarityType _rarityType;

    protected Weapon(string name, int minDamage, int maxDamage, int socketsCount, string rarityType)
    {
        this.Name = name;
        this.MinDamage = minDamage;
        this.MaxDamage = maxDamage;
        this.GemSockets = new Gem[socketsCount];

        for (int i = 0; i < socketsCount; i++)
        {
            this.GemSockets[i] = new Gem();
        }

        Enum.TryParse(rarityType, out this._rarityType);
    }

    public string Name { get; set; }

    public int MinDamage { get; set; }

    public int MaxDamage { get; set; }

    public IGem[] GemSockets { get; set; }

    public RarityType RarityType
    {
        get { return this._rarityType; }
        set { this._rarityType = value; }
    }

    public void AddGem(IGem gem, int index)
    {
        if (index >= 0 && index < this.GemSockets.Length)
        {
            //replaces the gem
            this.GemSockets[index] = gem;
        }
    }

    public void RemoveGem(int index)
    {
        if (index >= 0 && index < this.GemSockets.Length)
        {
            // puts an empty gem(0 stats) in the socket
            this.GemSockets[index] = new Gem();
        }
    }

    public string Print()
    {
       this.ModifyStatsBasedOnRarityType(this.RarityType);
       this.IncreaseWeaponStatsBasedOnGems();

        return this.ToString();
    }

    private void ModifyStatsBasedOnRarityType(RarityType rarityType)
    {
        switch (rarityType)
        {
            case RarityType.Common:
                this.MinDamage *= 1;
                this.MaxDamage *= 1;
                break;
            case RarityType.Uncommon:
                this.MinDamage *= 2;
                this.MaxDamage *= 2;
                break;
            case RarityType.Rare:
                this.MinDamage *= 3;
                this.MaxDamage *= 3;
                break;
            case RarityType.Epic:
                this.MinDamage *= 5;
                this.MaxDamage *= 5;
                break;
        }
    }

    public virtual void IncreaseWeaponStatsBasedOnGems()
    {
        foreach (var gem in this.GemSockets)
        {
            this.MinDamage += gem.Strenght * 2;
            this.MaxDamage += gem.Strenght * 3;
            this.MinDamage += gem.Agility * 1;
            this.MaxDamage += gem.Agility * 4;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(
            $"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, +{this.GemSockets.Sum(g => g.Strenght)} Strength, +{this.GemSockets.Sum(g => g.Agility)} Agility, +{this.GemSockets.Sum(g => g.Vitality)} Vitality");

        return sb.ToString().Trim();
    }
}