namespace _9RectangleIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(data[0]);
            int numberOfChecks = int.Parse(data[1]);
            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < n; i++)
            {
                var rectangleData = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                string Id = rectangleData[0];
                double width = double.Parse(rectangleData[1]);
                double height = double.Parse(rectangleData[2]);
                double topLeftX = double.Parse(rectangleData[3]);
                double topLeftY = double.Parse(rectangleData[4]);

                Rectangle rectangle = new Rectangle
                {
                    Id = Id,
                    Width = width,
                    Height = height,
                    TopLeftX = topLeftX,
                    TopLeftY = topLeftY
                };

                rectangles.Add(rectangle);
            }
            for (int i = 0; i < numberOfChecks; i++)
            {
                var rectangleIds = Console.ReadLine()
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                string rectangleOneId = rectangleIds[0];
                string rectangleTwoId = rectangleIds[1];

                var firstRectangle = rectangles.FirstOrDefault(r => r.Id == rectangleOneId);
                var secondRectangle = rectangles.FirstOrDefault(r => r.Id == rectangleTwoId);

                bool result = firstRectangle.CheckIfRectanglesIntersect(secondRectangle);
                if (result)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}