using System.Drawing;
namespace _9RectangleIntersection
{
    public class Rectangle
    {
        public string Id { get; set; }
        public double Width { get; set; }

        public double Height { get; set; }

        public double TopLeftX { get; set; }

        public double TopLeftY { get; set; }

        //public bool CheckIfRectanglesIntersect(Rectangle rectangle)
        //{
        //    //X1, Y1, X2, Y2: the coordinates of the points of the first rectangle(with X1 < X2 and Y1 < Y2)
        //    //X1', Y1', X2', Y2' : the coordinates of the points of the second rectangle(with X1' < X2' and Y1' < Y2')

        //    // (X2' >= X1 && X1' <= X2) && (Y2' >= Y1 && Y1' <= Y2)
        //    var x1 = this.TopLeftCoordinateX;
        //    var y1 = this.TopLeftCoordinateY;
        //    var x2 = this.TopLeftCoordinateX + this.Height;
        //    var y2 = this.TopLeftCoordinateY + this.Width;

        //    var x11 = rectangle.TopLeftCoordinateX;
        //    var y11 = rectangle.TopLeftCoordinateY;
        //    var x22 = rectangle.TopLeftCoordinateX + rectangle.Height;
        //    var y22 = rectangle.TopLeftCoordinateY + rectangle.Width;

        //    if ((x22 >= x1 && x11 <= x2) && (y22 >= y1 && y11 <= y2))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        //public bool CheckIfRectanglesIntersect(Rectangle r)
        //{
        //    System.Drawing.Rectangle s = new System.Drawing.Rectangle();
        //    return this.TopLeftCoordinateX < r.TopLeftCoordinateX + r.Width && this.TopLeftCoordinateX + this.Width > r.TopLeftCoordinateX && this.TopLeftCoordinateY < r.TopLeftCoordinateY + r.Height && this.TopLeftCoordinateY + this.Height > r.TopLeftCoordinateY;
        //}

        //public bool CheckIfRectanglesIntersect(Rectangle rect)
        //{
        //    return (rect.TopLeftX < this.TopLeftX + this.Width) &&
        //           (this.TopLeftX < (rect.TopLeftX + rect.Width)) &&
        //           (rect.TopLeftY < this.TopLeftY + this.Height) &&
        //           (this.TopLeftY < rect.TopLeftY + rect.Height);
        //}
        public bool CheckIfRectanglesIntersect(Rectangle rectangle)
        {
            return rectangle.TopLeftX + rectangle.Width >= this.TopLeftX &&
                   rectangle.TopLeftX <= this.TopLeftX + this.Width &&
                   rectangle.TopLeftY >= this.TopLeftY - this.Height &&
                   rectangle.TopLeftY - rectangle.Height <= this.TopLeftY;
        }
    }
}