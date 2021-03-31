using System;
using System.Collections.Generic;
using System.Text;

namespace Object.Person
{
    public class GeneratorFromPerson
    {
        private static readonly string[] _names =
        {
          "Игорь",
          "Арсен",
          "Кирилл",
          "Максим",
          "Даниил",
          "Георгий",
          "Фёдор",
          "Гордей",
          "Артём",
          "Никита",
        };

        private static readonly string[] _surnames =
        {
          "Попов",
          "Леонов",
          "Лебедев",
          "Курочкин",
          "Сафонов",
          "Максимов",
          "Виноградов",
          "Мухин",
          "Романов",
          "Малышев",
        };

        private static readonly string[] _patronymic =
        {
          "Арсентьевич",
          "Ильич",
          "Даниилович",
          "Алексеевич",
          "Маркович",
          "Александрович",
          "Егорович",
          "Александрович",
          "Адамович",
          "Сергеевич",
        };

        private static readonly string[] _towns =
        {
          "Москва",
          "Питер",
          "Ростов",
          "Уфа",
          "Киев",
          "Одесса",
          "Саранск",
          "Харьков",
          "Краснодар",
          "Самара",
        };

        private static readonly string[] _passportNumbers =
       {
            "1402014",
            "2305015",
            "5203049",
            "7408066",
            "8900029",
            "0509067",
            "5952028",
            "4401558",
            "8545054",
            "9032020",
        };

        private static readonly string[] _workPlace =
       {
            "Компания N-0",
            "Компания N-1",
            "Компания N-2",
            "Компания N-3",
            "Компания N-4",
            "Компания N-5",
            "Компания N-6",
            "Компания N-7",
            "Компания N-8",
            "Компания N-9",
        };

        public static string GeneratorPersonWorkPlace()
        {
            return _workPlace[_rand.Next(0, _workPlace.Length)];
        }

        static readonly Random _rand = new Random();

        public static string GenerateDateOfBirth()
        {
            DateTime start = new DateTime(1990, 1, 1);
            int range = ((TimeSpan)(new DateTime(2005, 1, 1) - start)).Days;
            return Convert.ToString(start.AddDays(_rand.Next(range)));
        }

        public static Person GeneratePerson()
        {
            return new Person(
            _names[_rand.Next(0, _names.Length)] +
            _surnames[_rand.Next(0, _surnames.Length)] +
            _patronymic[_rand.Next(0, _names.Length)],
             GenerateDateOfBirth(),
            _towns[_rand.Next(0, _towns.Length)],
            _passportNumbers[_rand.Next(0, _passportNumbers.Length)]);
        }

        public static PersonHandMadeHash GeneratePersonHandMadeHash()
        {
            return new PersonHandMadeHash(
            _names[_rand.Next(0, _names.Length)] +
            _surnames[_rand.Next(0, _surnames.Length)] +
            _patronymic[_rand.Next(0, _names.Length)],
             GenerateDateOfBirth(),
            _towns[_rand.Next(0, _towns.Length)],
            _passportNumbers[_rand.Next(0, _passportNumbers.Length)]);
        }
    }
}
