using System;

public class TrafficLight
{
    private ColorType _currentColor;

    public TrafficLight(string currentColor)
    {
        Enum.TryParse(currentColor, out this._currentColor);
    }

    public ColorType CurrentColor
    {
        get => this._currentColor;
        private set => this._currentColor = value;
    }

    public void ChangeColor()
    {
        if (this.CurrentColor == ColorType.Red)
        {
            this.CurrentColor = ColorType.Green;
        }
        else if (this.CurrentColor == ColorType.Green)
        {
            this.CurrentColor = ColorType.Yellow;
        }
        else if (this.CurrentColor == ColorType.Yellow)
        {
            this.CurrentColor = ColorType.Red;
        }
    }

    public override string ToString()
    {
        return $"{this.CurrentColor}";
    }
}