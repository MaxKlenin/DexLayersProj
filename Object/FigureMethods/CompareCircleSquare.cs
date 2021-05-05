using Object.Figure;
using Object.FigureInterface;
using System;

namespace Object.FigureMethods
{
    public class CompareCircleSquare<T, U> : ICircleSquareComparer<T, U> 
        where T : BaseFigure where U : BaseFigure
    {
        public delegate void Notifier(string message);
        public event Notifier Notify;

        private readonly T _figure1;
        private readonly U _figure2;

        public CompareCircleSquare(T figure1, U figure2)
        {
            _figure1 = figure1 ?? throw new ArgumentNullException(nameof(figure1));
            _figure2 = figure2 ?? throw new ArgumentNullException(nameof(figure2));
            Notify += PrintMessage;
        }

        public bool GetResultOfCompare()
        {
            if (_figure1.GetSquare() > _figure2.GetSquare())
            {
                Console.WriteLine("Square of figure1>figure2");
                return true;
            }
            else
            {
                Console.WriteLine("Square of figure2>figure1");
                return false;
            }
        }

        private void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
