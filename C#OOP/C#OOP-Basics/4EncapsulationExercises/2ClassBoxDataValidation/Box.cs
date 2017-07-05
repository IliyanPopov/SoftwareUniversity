namespace _2ClassBoxDataValidation
{
    using System;

    public class Box
    {
        private double _height;
        private double _length;
        private double _width;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        private double Length
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }
                this._length = value;
            }
        }

        private double Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }
                this._width = value;
            }
        }

        private double Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                this._height = value;
            }
        }


        public double CalculateSurfaceArea()
        {
            return (2 * this._length * this._width) + (2 * this._length * this._height) +
                   (2 * this._width * this._height);
        }

        public double CalculateLateeralSurface()
        {
            return (2 * this._length * this._height) + (2 * this._width * this._height);
        }

        public double CalculateVolume()
        {
            return this._length * this._width * this._height;
        }
    }
}