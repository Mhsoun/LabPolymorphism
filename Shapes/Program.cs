using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter circle radius");
            double circleRadius = double.Parse(Console.ReadLine());
            Shape circle = new Circle(circleRadius);
            Console.WriteLine("Enter rectangle height");
            double rectangleHeight =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rectangle width");
            double rectangleWidth = double.Parse(Console.ReadLine());
            Shape rectangle = new Rectangle(rectangleHeight,rectangleWidth);

            double circleArea = circle.CalculateArea();
            double circlePerimter = circle.CalculatePerimeter();
            Console.WriteLine($"the cirlce area is {circleArea} and the circle perimeter is {circlePerimter}");
            circle.Draw();

            double rectangleArea = rectangle.CalculateArea();
            double rectanglePerimeter = rectangle.CalculatePerimeter();
            Console.WriteLine($"The rectangle area is {rectangleArea} and the rectangle preimeter is {rectanglePerimeter}");
            rectangle.Draw();
            Console.ReadLine();
        }
    }
}
