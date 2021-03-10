using System;
using System.Diagnostics;

namespace SpeedBoxingUnboxingLibrary
{
    public static class BoxingUnboxing
    {
        public static void ShowBoxingUnboxing()
        {             
            int n = 1000;
            int x;
            object[] o = new object[n];

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Измерение времени выполнения при помощи класса Stopwatch");
            Console.WriteLine("****измеряем скорость boxing****");
            stopwatch.Start();
            for (int i = 0; i < n; i++)
            {
                o[i] = i;
            }
            stopwatch.Stop();
            Console.WriteLine("Средняя скорость операции =" + Convert.ToDouble(stopwatch.ElapsedTicks) / n);
            stopwatch.Reset();

            Console.WriteLine("****измеряем скорость unboxing****");
            stopwatch.Start();
            for (int i = 0; i < n; i++)
            {
                x = (int)o[i];
            }
            stopwatch.Stop();
            Console.WriteLine("Средняя скорость операции =" + Convert.ToDouble(stopwatch.ElapsedTicks) / n);
            stopwatch.Reset();

            Console.WriteLine("****измеряем скорость присваивания****");
            stopwatch.Start();
            for (int i = 0; i < n; i++)
            {
                x = 1;
            }
            stopwatch.Stop();
            Console.WriteLine("Средняя скорость операции =" + Convert.ToDouble(stopwatch.ElapsedTicks) / n);
            stopwatch.Reset();
        }
    }
}