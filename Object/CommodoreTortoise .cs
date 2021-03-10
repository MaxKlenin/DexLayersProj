using System;

namespace OOPLibrary.TortoiseType
{
    public class CommodoreTortoise : DefaultTortoise
    {
        protected string _lazerGun { get; } //useless set

        public CommodoreTortoise(string _name, string _body, string _shell, string _lazerGun) :
            base(_name, _body, _shell)
        {
            this._lazerGun = _lazerGun;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Название:" + _name + "\n Тип тела:" + _body + "\n Панцирь:" + _shell +
                "\n Лазер:" + _lazerGun + "\n");
        }
    }
}