using System.Collections;

public class RandomList : ArrayList
{
    public string RandomString(int index)
    {
        this.RemoveAt(index);
        var result = this[index];

        return result.ToString();
    }
}