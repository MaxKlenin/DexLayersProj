using Object.Figure;
using NUnit.Framework;
using System;
using Object.FigureComparer;
using System.Diagnostics;
using System.Collections.Generic;
using Object.FigureInterface;
using Object.FirureMethods;


namespace ObjectTests
{
    public class TestCovarianсeAndCounterCovarianсe
    {

        [Test]
        public void CompareCircleSquareTest()
        {
            ICircleSquareComparer<BaseFigure, BaseFigure> circleSquareComparer =
                new CompareCircleSquare<BaseFigure, BaseFigure>(new Circle(5), new Circle(7));
            Assert.IsNotNull(circleSquareComparer.GetResultOfCompare());
        }

        [Test]
        public void PrintFigureNameByEvetnTest()
        {
            IGetFigureName<Rectangle> printFigureMethodsResults =
                   new GetFigureNameByEvetn<BaseFigure>();
             
            Assert.DoesNotThrow(()=> printFigureMethodsResults.PrintFigureNameByEvetn(new Rectangle(1, 2)));
        }
    }
}
    
