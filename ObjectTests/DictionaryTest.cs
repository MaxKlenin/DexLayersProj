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

                    Console.WriteLine("#GeneratePersonsDictionary error# ArgumentException при добавление эл-а в словарь");
                }
            }
            return dict;
        }

        private bool IsContainsInDictionary(Dictionary<Person, string> dictionary, Person person)
        {
            stopwatch.Restart();
            bool result = dictionary.ContainsKey(person);
            stopwatch.Stop();
            return result;
        }

        private bool IsContainsInBadDictionary(Dictionary<PersonHandMadeHash, string> dictionary, PersonHandMadeHash person)
        {
            stopwatch.Restart();
            bool result = dictionary.ContainsKey(person);
            stopwatch.Stop();
            return result;
        }
    }
}
