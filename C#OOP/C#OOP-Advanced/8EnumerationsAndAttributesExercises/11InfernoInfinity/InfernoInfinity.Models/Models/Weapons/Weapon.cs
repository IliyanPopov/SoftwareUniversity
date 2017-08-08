namespace InfernoInfinity.Models.Models.Weapons
{
    using System;
    using System.Linq;
    using System.Text;
    using Common.CustomAttributes;
    using Contracts.Gems;
    using Contracts.Weapons;
    using Enumerations;

    [Description("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public abstract class Weapon : IWeapon
    {
        private int _maxDamage;
        private int _minDamage;
        private RarityType _rarityType;

        protected Weapon(string name, int minDamage, int maxDamage, int socketsCount, string rarityType)
        {
            Enum.TryParse(rarityType, out this._rarityType);
            this.Name = name;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.GemSockets = new IGem[socketsCount];
        }

        public string Name { get; set; }

        public int MinDamage
        {
            get
            {
                return this._minDamage + this.GemSockets.Where(g => g != null).Sum(g => g.Strenght * 2) +
                       +this.GemSockets.Where(g => g != null).Sum(g => g.Agility * 1);
            }
            private set { this._minDamage = value * (int) this.RarityType; }
        }

        public int MaxDamage
        {
            get
            {
                return this._maxDamage + this.GemSockets.Where(g => g != null).Sum(g => g.Strenght * 3) +
                       +this.GemSockets.Where(g => g != null).Sum(g => g.Agility * 4);
            }
            private set { this._maxDamage = value * (int) this.RarityType; }
        }

        public IGem[] GemSockets { get; set; }

        public RarityType RarityType
        {
            get { return this._rarityType; }
            set { this._rarityType = value; }
        }

        public string Print()
        {
            //IncreaseWeaponStatsBasedOnGems();

            return ToString();
        }

        //bug here
        //private void IncreaseWeaponStatsBasedOnGems()
        //{
        //    foreach (var gem in this.GemSockets.Where(g => g != null))
        //    {
        //        this.MinDamage += gem.Strenght * 2;
        //        this.MaxDamage += gem.Strenght * 3;
        //        this.MinDamage += gem.Agility * 1;
        //        this.MaxDamage += gem.Agility * 4;
        //    }
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(
                $"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, +{this.GemSockets.Where(g => g != null).Sum(g => g.Strenght)} Strength, +{this.GemSockets.Where(g => g != null).Sum(g => g.Agility)} Agility, +{this.GemSockets.Where(g => g != null).Sum(g => g.Vitality)} Vitality");

            return sb.ToString().Trim();
        }
    }
}