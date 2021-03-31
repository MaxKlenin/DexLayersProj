using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using Object.Person;

namespace ObjectTests
{
    public class DictionaryTest
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

            stopwatch.Reset();

            var dict = new Dictionary<Person, string>();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    var person = GeneratorFromPerson.GeneratePerson();
                    string workPlace = GeneratorFromPerson.GeneratorPersonWorkPlace();

                    stopwatch.Start();
                    dict.Add(person, workPlace);
                    stopwatch.Stop();
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

            stopwatch.Reset();

            var dict = new Dictionary<PersonHandMadeHash, string>();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    var person = GeneratorFromPerson.GeneratePersonHandMadeHash();
                    string workPlace = GeneratorFromPerson.GeneratorPersonWorkPlace();

                    stopwatch.Start();
                    dict.Add(person, workPlace);
                    stopwatch.Stop();
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

            stopwatch.Reset();

            var list = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    var person = GeneratorFromPerson.GeneratePerson();

                    stopwatch.Start();
                    list.Add(person);
                    stopwatch.Stop();
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

            stopwatch.Reset();

            var list = new List<PersonHandMadeHash>();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    var person = GeneratorFromPerson.GeneratePersonHandMadeHash();

                    stopwatch.Start();
                    list.Add(person);
                    stopwatch.Stop();
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

        private void SetInstanceCount(int count)
        {

        }


    }
}
