namespace Object
{
    public class Fruit
    {
        public readonly string Name;
        public readonly double Weight;

        public Fruit(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return Name + " Вес:" + Weight;
        }
    }
}