namespace _4ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private decimal _money;
        private string _name;

        public Person(string name, decimal money)
        {
            this.Money = money;
            this.Name = name;
            this.Products = new List<Product>();
        }

        public List<Product> Products { get; set; }

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

        public decimal Money
        {
            get { return this._money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this._money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (this._money < product.Cost)
            {
                throw new ArgumentException($"{this._name} can't afford {product.Name}");
            }
            this._money -= product.Cost;
            this.Products.Add(product);
        }
    }
}