namespace _4ShoppingSpree
{
    using System;

    public class Product
    {
        private decimal _cost;
        private string _name;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get { return this._name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this._name = value;
            }
        }

        public decimal Cost
        {
            get { return this._cost; }
            set
            {
                //if (value < 0)
                //{
                //    throw new ArgumentException("Cost cannot be a negative number.");
                //}
                this._cost = value;
            }
        }

        public override string ToString()
        {
            return $"{this._name}";
        }
    }
}