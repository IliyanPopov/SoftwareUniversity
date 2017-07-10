public abstract class Animal
{
    private string _favouriteFood;
    private string _name;

    protected Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public string FavouriteFood
    {
        get { return this._favouriteFood; }
        set { this._favouriteFood = value; }
    }

    public abstract string ExplainMyself();
}