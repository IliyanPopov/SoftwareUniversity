using System.Collections.Generic;
using System.Linq;

public class StackOfStrings
{
    private List<string> _data;

    public void Push(string item)
    {
        this._data.Add(item);
    }

    public string Pop()
    {
        var result = this._data.Last();
        this._data.Remove(result);

        return result;
    }

    public string Peek()
    {
        return this._data.Last();
    }

    public bool IsEmpty()
    {
        return this._data.Count < 0;
    }
}

