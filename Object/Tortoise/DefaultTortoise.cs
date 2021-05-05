using System;

namespace Object.Tortoise
{
    public class DefaultTortoise : BaseTortoise
    {
        protected DefaultTortoise(string name, string body, string shell) :
            base(name, body, shell)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Название:" + Name + "\n Тип тела:" + Body + "\n Панцирь:" + Shell + "\n");
        }
    }
}