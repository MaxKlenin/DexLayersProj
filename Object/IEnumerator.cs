using System.Collections;

namespace Object
{
    public class FruitEnumerator : IEnumerator
    {
        public Fruit[] Fruits;
        private int _position = -1;

        public FruitEnumerator(Fruit[] items)
        {
            Fruits = items;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < Fruits.Length;
        }

        public void Reset()
        {
            _position = -1;
        }

        public Fruit Current
        {
            get
            {
                return Fruits[_position];
            }
        }

        object IEnumerator.Current => Current;

    }
}