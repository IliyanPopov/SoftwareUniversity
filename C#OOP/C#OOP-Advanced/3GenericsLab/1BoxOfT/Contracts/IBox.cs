public interface IBox<T>
{
    void Add(T t);

    T Remove();

    int Count { get; }
}

