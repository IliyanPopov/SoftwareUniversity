public class Treeuple<T1, T2, T3> : CustomTuple<T1, T2>
{
    public T3 Item3 { get; }

    public Treeuple(T1 item1, T2 item2, T3 item3) : base(item1, item2)
    {
        this.Item3 = item3;
    }

    public override string ToString()
    {
        return base.ToString()+ $" -> {this.Item3}";
    }
}

