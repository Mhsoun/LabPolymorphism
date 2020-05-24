using System;


namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double CalculateArea() => Radius * Math.PI;

        public override double CalculatePerimeter() => 2 * Math.PI * Radius;

        public override void Draw()
        {

            double thickness = 0.4;
            ConsoleColor BorderColor = ConsoleColor.Red;
            Console.ForegroundColor = BorderColor;
            char symbol = '*';
            Console.WriteLine();
            double rIn = Radius - thickness, rOut = Radius + thickness;

            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
