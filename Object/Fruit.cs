namespace Object
{
    public abstract class Fruit
    {
        private readonly string _name;
        private readonly double _weight;

        protected Fruit(string name, double weight)
        {
            this._name = name;
            this._weight = weight;
        }

        public override string ToString()
        {
            return _name + " Вес:" + _weight;
        }
    }
}