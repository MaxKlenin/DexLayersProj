using System;

namespace Object.Figure
{
    public class Circle : BaseFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius > 0)
            {
                _radius = radius;
            }
            else throw new ArgumentException("Радиус не верно введён.");
        }

        public override double GetSquare()
        {
            return Math.Round(Math.Pow(_radius, 2) * Math.PI, 2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * Math.PI * _radius, 2);
        }

        public override string ToString()
        {
            return "Circle";
        }
    }
}
