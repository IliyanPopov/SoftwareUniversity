namespace InfernoInfinity.Models.Models.Gems
{
    using System;
    using Contracts.Gems;
    using Enumerations;

    public abstract class Gem : IGem
    {
        private int _agility;
        private GemClarityType _clarityType;
        private int _strenght;
        private int _vitality;


        protected Gem(string gemClarityType, int strenght, int agility, int vitality)
        {
            Enum.TryParse(gemClarityType, out this._clarityType);
            this.Strenght = strenght;
            this.Agility = agility;
            this.Vitality = vitality;
        }


        public GemClarityType ClarityType
        {
            get { return this._clarityType; }
            set { this._clarityType = value; }
        }

        public int Strenght
        {
            get { return this._strenght; }
            private set { this._strenght = value + (int) this.ClarityType; }
        }

        public int Agility
        {
            get { return this._agility; }
            private set { this._agility = value + (int) this.ClarityType; }
        }

        public int Vitality
        {
            get { return this._vitality; }
            private set { this._vitality = value + (int) this.ClarityType; }
        }
    }
}