using System;

namespace Object.Tortoise
{
    public class CommodoreTortoise : DefaultTortoise
    {
        protected string LazerGun { get; }

        public CommodoreTortoise(string name, string body, string shell, string lazerGun) :
            base(name, body, shell)
        {
            this.LazerGun = lazerGun;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Название:" + Name + "\n Тип тела:" + Body + "\n Панцирь:" + Shell +
                "\n Лазер:" + LazerGun + "\n");
        }
    }
}