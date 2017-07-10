using System;
using System.Text;

public class Book
{
    private string _author;
    private decimal _price;
    private string _title;


    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public virtual decimal Price
    {
        get { return this._price; }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }

            this._price = value;
        }
    }


    public virtual string Author
    {
        get { return this._author; }
        protected set
        {
            var names = value.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            if (names.Length > 2)
            {
                var lastName = names[names.Length - 1];
                if (char.IsDigit(lastName[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }

            this._author = value;
        }
    }


    public virtual string Title
    {
        get { return this._title; }
        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }

            this._title = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Type: ").AppendLine(GetType().Name)
            .Append("Title: ").AppendLine(this.Title)
            .Append("Author: ").AppendLine(this.Author)
            .Append("Price: ").Append($"{this.Price:f1}")
            .AppendLine();

        return sb.ToString();
    }
}