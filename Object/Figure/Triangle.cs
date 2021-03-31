using System;

namespace Object.Figure
{
    public class Triangle : BaseFigure
    {
        private readonly double _x;
        private readonly double _y;
        private readonly double _z;

        public Triangle(double x, double y, double z)
        {
            if (x <= 0 || y <= 0 || z <= 0)
                throw new ArgumentException("У треугольника заданны стороны ранвые нулю");
            else
            {
                if (x + y < z || y + z < x || x + z < y)
                    throw new ArgumentException("Такого треугольника не существует");
                else
                {
                    _x = x;
                    _y = y;
                    _z = z;
                }
            }
        }

        public override double GetSquare()
        {
            double p = (_x + _y + _z) / 2;
            return Math.Round(Math.Sqrt(p * (p - _x) * (p - _y) * (p - _z)), 2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(_x + _y + _z, 2);
        }

        public override string ToString()
        {
            return "Triangle";
        }
    }
}
