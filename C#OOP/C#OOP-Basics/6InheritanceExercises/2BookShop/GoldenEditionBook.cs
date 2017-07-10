using System;

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price)
    {
    }

    public override decimal Price
    {
        get { return base.Price * 1.3M; }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            base.Price = value;
        }
    }
}