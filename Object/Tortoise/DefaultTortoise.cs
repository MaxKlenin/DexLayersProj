using System;

namespace OOPLibrary.TortoiseType
{
    public class DefaultTortoise : BaseTortoise
    {
        public DefaultTortoise(string _name, string _body, string _shell) :
            base(_name, _body, _shell)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Название:" + _name + "\n Тип тела:" + _body + "\n Панцирь:" + _shell + "\n");
        }
    }
}