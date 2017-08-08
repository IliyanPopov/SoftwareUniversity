using System.ComponentModel;

public class BlackBoxInt
{
    private int _intValue;

    private void Add(int number)
    {
        this._intValue += number;
    }

    private void Substract(int number)
    {
        this._intValue -= number;
    }

    private void Multiply(int number)
    {
        this._intValue *= number;
    }
    private void Divide(int number)
    {
        this._intValue /= number;
    }

    private void LeftShift(int number)
    {
        this._intValue = this._intValue << number;
    }
    private void RightShift(int number)
    {
        this._intValue = this._intValue >> number;
    }
}

