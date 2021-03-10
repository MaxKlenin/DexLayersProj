namespace OOPLibrary.TortoiseType
{
    public abstract class BaseTortoise
    {
        protected string _name { get; }
        protected string _body { get; }
        protected string _shell { get; }

        protected BaseTortoise(string _name, string _body, string _shell)
        {
            this._name = _name;
            this._body = _body;
            this._shell = _shell;
        }

        public abstract void ShowInfo();
    }
}
