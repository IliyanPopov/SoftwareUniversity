namespace _1ClassBox
{
    public class Box
    {
        private double _lenght;
        private double _width;
        private double _height;

        public Box(double lenght, double width, double height)
        {
            this._lenght = lenght;
            this._width = width;
            this._height = height;
        }

        public double CalculateSurfaceArea()
        {
            return (2 * this._lenght * this._width) + (2 * this._lenght * this._height) +
                   (2 * this._width * this._height);
        }

        public double CalculateLateeralSurface()
        {
            return (2 * this._lenght * this._height) + (2 * this._width * this._height);
        }

        public double CalculateVolume()
        {
            return this._lenght * this._width * this._height;
        }
    }
}