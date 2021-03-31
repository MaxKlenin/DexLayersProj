using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace ConsoleApp1
{
    class MyDelegate
    {
        List<Action> methodList = new List<Action>();

        public MyDelegate()
        {
        }

        public void add(Action sadasd)
        {
            methodList.Add(sadasd);
        }

        public void WriteMyDelegate()
        {
            foreach (var item in methodList)
            {
                item.Invoke();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate asd = new MyDelegate();
            asd.add(Hello);
            asd.add(Hello);
            asd.add(Hello);
            asd.add(Hello);
            asd.WriteMyDelegate();
        }

        private static void Hello()
        {

            Console.WriteLine("Hello sadasd asd");
        }

    }
}