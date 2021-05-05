using Object.Figure;
using NUnit.Framework;
using System;
using Object.FigureCompare;

namespace ObjectTests
{
    
    public class IComparableTest
    {
        private BaseFigure[] _fArray;
        private enum TypeOfParameters { Perimeter, Square }

        private void CreateArr()
        {
            var rand = new Random();
            _fArray = new BaseFigure[100];
            int i = 0;
            while (i < _fArray.Length)
            {
                switch (i % 3)
                {
                    case 0:
                        _fArray[i] = new Circle(rand.Next(1, 10));
                        break;
                    case 1:
                        _fArray[i] = new Rectangle(rand.Next(1, 5), rand.Next(1, 5));
                        break;
                    case 2:
                        try
                        {
                            _fArray[i] = new Triangle(rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 11));
                        }
                        catch (Exception)
                        {
                            i--;
                        }
                        break;
                }
                i++;
            }
        }

        private void SortByPerimeter()
        {
            Array.Sort(_fArray, new PerimeterComparer());
        }

        private void SortBySquare()
        {
            Array.Sort(_fArray, new SquareComparer());
        }

        private void PrintArray(TypeOfParameters type)
        {
            foreach (var figure in _fArray)
            {
                if (type == TypeOfParameters.Perimeter)
                {
                    Console.WriteLine(figure + " площадь: " + figure.GetSquare());
                }
                else
                {
                    Console.WriteLine(figure + " периметр: " + figure.GetPerimeter());
                }
            }
            Console.WriteLine();
        }

        private bool IsSorted(BaseFigure[] fArray, TypeOfParameters parameters)
        {
            if (fArray == null)
            {
                throw new ArgumentException("Передаваемый массив == null.");
            }
            for (int i = 1; i < fArray.Length; i++)
            {
                if (parameters == TypeOfParameters.Square)
                {
                    if (fArray[i - 1].GetSquare() > fArray[i].GetSquare())
                    {
                        return false;
                    }
                }
                else
                {
                    if (fArray[i - 1].GetPerimeter() > fArray[i].GetPerimeter())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        [SetUp]
        public void Setup()
        {
            CreateArr();
        }

        [Test]
        public void SortBySquareTest()
        {
            SortBySquare();
            PrintArray(TypeOfParameters.Square);
            Assert.True(IsSorted(_fArray, TypeOfParameters.Square));
        }

        [Test]
        public void SortByPerimeterTest()
        {
            SortByPerimeter();
            PrintArray(TypeOfParameters.Perimeter);
            Assert.True(IsSorted(_fArray, TypeOfParameters.Perimeter));
        }
    }
}
