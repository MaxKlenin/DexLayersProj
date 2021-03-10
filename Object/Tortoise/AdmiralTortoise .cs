using System;

namespace OOPLibrary.TortoiseType
{
    public class AdmiralTortoise : CommodoreTortoise
    {
        protected string _rpg { get; }
        protected string _teslaGun { get; }

        public AdmiralTortoise(string _name, string _body, string _shell, string _lazerGun, string _rpg, string _teslaGun) :
            base(_name, _body, _shell, _lazerGun)
        {
            this._rpg = _rpg;
            this._teslaGun = _teslaGun;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Название:" + _name + "\n Тип тела:" + _body + "\n Панцирь:" + _shell +
                "\n Лазер:" + _lazerGun + "\n РПГ:" + _rpg + "\n Тесла-пушка:" + _teslaGun + "\n");
        }
    }
}
