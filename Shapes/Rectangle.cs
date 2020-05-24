using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }

        public override double CalculateArea() => Width * Height;

        public override double CalculatePerimeter() => Width * Width + Height * Height;

        public override void Draw()
        {
            var star = '*';
            var spc = ' ';
            DrawLine(this.Width, star, star);//width ==4 the line look like this "****"
            for (int i = 1; i < this.Height - 1; i++)//hight == 4 draw 3 lines
            {
                Console.WriteLine("");
                DrawLine(this.Width, spc, star);//width ==4  the line looks like this " ** "
            }
            Console.WriteLine("");
            DrawLine(this.Width, star, star);//width ==4 the line look like this "****"
        }
        private void DrawLine(double width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; i++)
            {
                Console.Write(mid);
            }
            Console.Write(end);
        }

    }
}
