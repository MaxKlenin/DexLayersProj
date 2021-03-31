using System;
using System.Collections.Generic;
using System.Text;

namespace Object.Person
{
    class GeneratorFromPerson
    {
        private readonly string[] _names =
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

        private readonly string[] _surnames =
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

        private readonly string[] _patronymic =
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

        private readonly string[] _towns =
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

        private readonly string[] _passportNumbers =
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

        readonly Random _rand = new Random();

        public string GenerateDateOfBirth()
        {
            DateTime start = new DateTime(1990, 1, 1);
            int range = ((TimeSpan)(new DateTime(2005, 1, 1) - start)).Days;
            return Convert.ToString(start.AddDays(_rand.Next(range)));
        }

        public Person GeneratePerson()
        {
            return new Person(
            _names[_rand.Next(0, _names.Length)] +
            _surnames[_rand.Next(0, _surnames.Length)] +
            _patronymic[_rand.Next(0, _names.Length)],
             GenerateDateOfBirth(),
            _towns[_rand.Next(0, _towns.Length)],
            _passportNumbers[_rand.Next(0, _passportNumbers.Length)]);
        }

        public PersonHandMadeHash GeneratePersonHandMadeHash()
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
