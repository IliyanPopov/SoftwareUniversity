namespace _15DrawingTool
{
    using System;
    using System.Text;

    public class CorDraw
    {
        public CorDraw(Shape shape)
        {
            this.Shape = shape;
        }

        public Shape Shape { get; set; }

        public void Draw()
        {
            Console.WriteLine($"|{Stringer("-", this.Shape.SideX)}|");       
            for (int i = 0; i < this.Shape.SideY-2; i++)
            {
                Console.WriteLine($"|{Stringer(" ", this.Shape.SideX)}|");
            }
            Console.WriteLine($"|{Stringer("-", this.Shape.SideX)}|");
        }

        private static string Stringer(string inputString, int stringLength)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < stringLength; i++)
            {
                result.Append(inputString);
            }

            return result.ToString();
        }
    }
}