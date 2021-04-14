using System;
using System.Collections.ObjectModel;

namespace Object
{
    public class UniqueCollection<T>
    {
        private Collection<T> _collection;

        public UniqueCollection()
        {
            _collection = new Collection<T>();
        }

        public void Add(T t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("Попытка добавить null в колллекцию.");
            }
            else
            {
                if (_collection.Contains(t))
                {
                    throw new ArgumentException("Ошибка добавления инснаса " + t + ".\nКоллекция хранит только уникальные объекты.");
                }
                else
                {
                    _collection.Add(t);
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Коллекция содержит элементы {0}:", typeof(T));
            foreach (T t in _collection)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine();
        }


        public void Clear ()
        {
            _collection.Clear();
        }

    }
}
