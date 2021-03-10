using System;

namespace Object.Figure
{
    public class Rectangle : BaseFigure
    {
        private readonly double _x;
        private readonly double _y;

        public Rectangle(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                _x = x;
                _y = y;
            }
            else throw new ArgumentException("Wrong format Rectangle");
        }

        public override double GetSquare()
        {
            return Math.Round(_x * _y, 2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * (_x + _y), 2);
        }

        public override string ToString()
        {
            return "Rectangle";
        }
    }
}
