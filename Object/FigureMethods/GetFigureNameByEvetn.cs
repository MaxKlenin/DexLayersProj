using System;
using Object.FigureInterface;
using Object.Figure;

namespace Object.FirureMethods
{
   public class GetFigureNameByEvetn<T> : IGetFigureName<T> where T: BaseFigure
    {
        public delegate void Notifier(string message);
        public event Notifier Notify;
         
        public void PrintFigureNameByEvetn(T figure)
        {
            if (figure == null)
            {
                throw new ArgumentNullException(nameof(figure));
            }

            if (Notify == null)
            {
                Notify += PrintMessage;
            }

            Notify?.Invoke("Figure - " + figure.ToString());
        }
        
        private void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
