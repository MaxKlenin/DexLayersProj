namespace Object.Tortoise
{
    public abstract class BaseTortoise
    {
        protected string Name { get; }
        protected string Body { get; }
        protected string Shell { get; }

        protected BaseTortoise(string name, string body, string shell)
        {
            this.Name = name;
            this.Body = body;
            this.Shell = shell;
        }

        public abstract void ShowInfo();
    }
}
