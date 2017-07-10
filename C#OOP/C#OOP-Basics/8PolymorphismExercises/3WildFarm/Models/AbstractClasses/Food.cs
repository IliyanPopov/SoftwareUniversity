public abstract class Food
{
    private int _quantity;

    protected Food(int quantity)
    {
        this.Quantity = quantity;
    }
    public int Quantity
    {
        get { return this._quantity; }
        set { this._quantity = value; }
    }
}
