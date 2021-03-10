using Object.Figure;
using NUnit.Framework;
using System;
using Object.FigureComparer;

namespace ObjectTests
{
    
    public class IComparableTest
    {
        private static BaseFigure[] _fArray;

        private enum TypeOfParameters { Perimeter, Square }

        private static void _createArr()
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

        private void _sortByPerimeter()
        {
            Array.Sort(_fArray, new PerimeterComparer());
        }

        private void _sortBySquare()
        {
            Array.Sort(_fArray, new SquareComparer());
        }

        private void _printArray(TypeOfParameters type)
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

        private bool _isSorted(BaseFigure[] fArray, TypeOfParameters parameters)
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
            _createArr();
        }

        [Test]
        public void SortBySquareTest()
        {
            _sortBySquare();
            _printArray(TypeOfParameters.Square);
            Assert.True(_isSorted(_fArray, TypeOfParameters.Square));
        }

        [Test]
        public void SortByPerimeterTest()
        {
            _sortByPerimeter();
            _printArray(TypeOfParameters.Perimeter);
            Assert.True(_isSorted(_fArray, TypeOfParameters.Perimeter));
        }

    }
}
