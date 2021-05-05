using Object.Figure;
using NUnit.Framework;
using System;
using Object.FigureCompare;
using System.Diagnostics;
using System.Collections.Generic;
using Object.Person;

namespace ObjectTests
{
    public class DictionaryVSListTest
    {
        private static Random _rand = new Random();

        private static Stopwatch stopwatch = new Stopwatch();

        private Dictionary<Person, string> GeneratePersonsDictionary(int count)
        {
            if (count<=0)
            {
                throw new ArgumentException("#GeneratePersonsDictionary error# " +
                    "присвоенно неверное знаечение параметру count");
            }

            var dict = new Dictionary<Person, string>();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    var person = GeneratorFromPerson.GeneratePerson();
                    string workPlace = GeneratorFromPerson.GeneratorPersonWorkPlace();
                    dict.Add(person, workPlace);
                }
                catch (ArgumentException)
                {

                    Console.WriteLine("#GeneratePersonsDictionary error# ArgumentException при добавление эл-а в словарь");
                }
            }
            return dict;
        }

        private Dictionary<PersonHandMadeHash, string> GeneratePersonsDictionaryWithHandMadeHash(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("#GeneratePersonsDictionary error# " +
                    "присвоенно неверное знаечение параметру count");
            }

            var dict = new Dictionary<PersonHandMadeHash, string>();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    var person = GeneratorFromPerson.GeneratePersonHandMadeHash();
                    string workPlace = GeneratorFromPerson.GeneratorPersonWorkPlace();
                    dict.Add(person, workPlace);
                }
                catch (ArgumentException)
                {

                    Console.WriteLine("#GeneratePersonsDictionaryWithHandMadeHash error# " +
                        "ArgumentException при добавление эл-а в словарь");
                }
            }
            return dict;
        }

        private List<Person> GeneratePersonsList(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("#GeneratePersonsDictionary error# " +
                    "присвоенно неверное знаечение параметру count");
            }

            var list = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    var person = GeneratorFromPerson.GeneratePerson();
                    list.Add(person);
                }
                catch (ArgumentException)
                {

                    Console.WriteLine("#GeneratePersonsList error# ArgumentException при добавление эл-а в словарь");
                }
            }
            return list;
        }

        private List<PersonHandMadeHash> GeneratePersonsListWithHandMadeHash(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("#GeneratePersonsDictionary error# " +
                    "присвоенно неверное знаечение параметру count");
            }

            var list = new List<PersonHandMadeHash>();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    var person = GeneratorFromPerson.GeneratePersonHandMadeHash();
                    list.Add(person);
                }
                catch (ArgumentException)
                {

                    Console.WriteLine("#GeneratePersonHandMadeHash error# ArgumentException при добавление эл-а в словарь");
                }
            }
            return list;
        }

        private bool FindInDictionary(Dictionary<Person, string> dictionary, Person person)
        {
            stopwatch.Restart();
            bool result = dictionary.ContainsKey(person);
            stopwatch.Stop();
            return result;
        }

        private bool FindInDictionary(Dictionary<PersonHandMadeHash, string> dictionary, PersonHandMadeHash person)
        {
            stopwatch.Restart();
            bool result = dictionary.ContainsKey(person);
            stopwatch.Stop();
            return result;
        }

        private bool FindInList(PersonHandMadeHash person, List<PersonHandMadeHash> list)
        {
            stopwatch.Restart();
            bool result = list.Contains(person);
            stopwatch.Stop();
            return result;
        }

        private bool FindInList(Person person, List<Person> list)
        {
            stopwatch.Restart();
            bool result = list.Contains(person);
            stopwatch.Stop();
            return result;
        }

        private bool FindInListVSDictionary(int count)
        {
            Dictionary<Person, string> dictOfPerson = GeneratePersonsDictionary(count);
            List<Person> listOfPeorson = GeneratePersonsList(count);

            Dictionary<Person, string>.KeyCollection keys = dictOfPerson.Keys;
            Person[] keysPerson = new Person[keys.Count];
            keys.CopyTo(keysPerson, 0);
            Person person = keysPerson[_rand.Next(0, keys.Count)];

            FindInDictionary(dictOfPerson, person);
            Console.WriteLine("На поиск элемента в словаре с " + count + " элементов с генерированным хешем ушло : " + 
                stopwatch.ElapsedMilliseconds + " миллисекунд");
            long stopwatchTime = stopwatch.ElapsedMilliseconds;

            FindInList(person, listOfPeorson);
            Console.WriteLine("На поиск элемента в cписке с " + count + " элементов с генерированным хешем ушло : " +
                stopwatch.ElapsedMilliseconds + " миллисекунд");

            if (stopwatch.ElapsedMilliseconds > stopwatchTime)
                return true;
            else return false;
        }

        private bool FindInListVSDictionaryHandMadeHash(int count)
        {
            Dictionary<PersonHandMadeHash, string> dictOfPerson = GeneratePersonsDictionaryWithHandMadeHash(count);
            List<PersonHandMadeHash> listOfPeorson = GeneratePersonsListWithHandMadeHash(count);

            Dictionary<PersonHandMadeHash, string>.KeyCollection keys = dictOfPerson.Keys;
            PersonHandMadeHash[] keysPerson = new PersonHandMadeHash[keys.Count];
            keys.CopyTo(keysPerson, 0);
            PersonHandMadeHash person = keysPerson[_rand.Next(0, keys.Count)];

            FindInDictionary(dictOfPerson, person);
            Console.WriteLine("На поиск элемента в словаре с " + count + " элементов с const хешем ушло : " +
                stopwatch.ElapsedMilliseconds + " миллисекунд");
            long stopwatchTime = stopwatch.ElapsedMilliseconds;

            FindInList(person, listOfPeorson);
            Console.WriteLine("На поиск элемента в cписке с " + count + " элементов с const хешем ушло : " +
                stopwatch.ElapsedMilliseconds + " миллисекунд");

            if (stopwatch.ElapsedMilliseconds > stopwatchTime)
                return true;
            else return false;
        }

        [Test]
        public void FindInListVSDictionaryIn100Instance()
        {
            int count = 100;

           bool listIsBetter = FindInListVSDictionary(count);

            Assert.IsTrue(!listIsBetter);
        }

        [Test]
        public void FindInListVSDictionaryIn10000Instance()
        {
            int count = 10000;

            bool listIsBetter = FindInListVSDictionary(count);

            Assert.IsTrue(!listIsBetter);
        }

        [Test]
        public void FindInListVSDictionaryWithHandMadeHashIn100000Instance()
        {
            int count = 100000;

            bool dictIsBetter = FindInListVSDictionaryHandMadeHash(count);

            Assert.IsTrue(dictIsBetter);
        }
    }
}
