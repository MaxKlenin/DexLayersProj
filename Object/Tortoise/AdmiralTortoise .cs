using System;

namespace Object.Tortoise
{
    public class AdmiralTortoise : CommodoreTortoise
    {
        private string Rpg { get; }
        private string TeslaGun { get; }

        public AdmiralTortoise(string name, string body, string shell, string lazerGun, string rpg, string teslaGun) :
            base(name, body, shell, lazerGun)
        {
            this.Rpg = rpg;
            this.TeslaGun = teslaGun;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Название:" + Name + "\n Тип тела:" + Body + "\n Панцирь:" + Shell +
                "\n Лазер:" + LazerGun + "\n РПГ:" + Rpg + "\n Тесла-пушка:" + TeslaGun + "\n");
        }
    }
}
