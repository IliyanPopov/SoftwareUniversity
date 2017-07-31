using System;

public class Gem : IGem
{
    private GemClarityType _clarityType;
    private GemType _type;

    public Gem()
    {
    }

    public Gem(string gemClarityType = "None", string type = "None")
    {
        Enum.TryParse(gemClarityType, out this._clarityType);
        Enum.TryParse(type, out this._type);
        this.IncreaseGemStats(this.ClarityType);

        switch (type)
        {
            case "Amethyst":
                this.Strenght += Constants.AmethystStrenghtBonus;
                this.Agility += Constants.AmethystAgilityBonus;
                this.Vitality += Constants.AmethystVitalityBonus;
                break;
            case "Emerald":
                this.Strenght += Constants.EmeraldStrenghtBonus;
                this.Agility += Constants.EmeraldAgilityBonus;
                this.Vitality += Constants.EmeraldVitalityBonus;
                break;
            case "Ruby":
                this.Strenght += Constants.RubyStrenghtBonus;
                this.Agility += Constants.RubyAgilityBonus;
                this.Vitality += Constants.RubyVitalityBonus;
                break;
        }
    }

    public GemClarityType ClarityType
    {
        get { return this._clarityType; }
        set { this._clarityType = value; }
    }

    public GemType Type
    {
        get { return this._type; }
        set { this._type = value; }
    }

    public int Strenght { get; set; }

    public int Agility { get; set; }

    public int Vitality { get; set; }

    protected void IncreaseGemStats(GemClarityType gemClarityType)
    {
        switch (gemClarityType)
        {
            case GemClarityType.Chipped:
                this.Strenght += Constants.ChippedGemBonusToStrenght;
                this.Agility += Constants.ChippedGemBonusToAgility;
                this.Vitality += Constants.ChippedGemBonusToVitality;
                break;
            case GemClarityType.Regular:
                this.Strenght += Constants.RegularGemBonusToStrenght;
                this.Agility += Constants.RegularGemBonusToAgility;
                this.Vitality += Constants.RegularGemBonusToVitality;
                break;
            case GemClarityType.Perfect:
                this.Strenght += Constants.PerfectGemBonusToStrenght;
                this.Agility += Constants.PerfectGemBonusToAgility;
                this.Vitality += Constants.PerfectGemBonusToVitality;
                break;
            case GemClarityType.Flawless:
                this.Strenght += Constants.FlawlessGemBonusToStrenght;
                this.Agility += Constants.FlawlessGemBonusToAgility;
                this.Vitality += Constants.FlawlessGemBonusToVitality;
                break;
        }
    }
}