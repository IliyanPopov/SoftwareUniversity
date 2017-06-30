namespace _15DrawingTool
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            if (input == "Square")
            {
                int side = int.Parse(Console.ReadLine());
                Square square = new Square
                {
                    SideY = side,
                    SideX = side
                };
                CorDraw corDraw = new CorDraw(square);
                corDraw.Draw();
            }
            else if (input == "Rectangle")
            {
                int sideX = int.Parse(Console.ReadLine());
                int sideY = int.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle
                {
                    SideX = sideX,
                    SideY = sideY
                };
                CorDraw corDraw = new CorDraw(rectangle);
                corDraw.Draw();
            }
        }
    }
}