using System;

namespace Object.Person
{
    public class Person
    {
        public readonly string _fullName;
        public readonly string _dateOfBirth;
        public readonly string _placeOfBirth;
        public readonly string _passportNumber;

        public Person()
        {
            /*_fullName = "";
            _dateOfBirth = "";
            _placeOFBirth = "";
            _passportNumber = "";*/
        }

        public Person(String fullName, String dateOfBirth, String placeOFBirth, String passportNumber)
        {
           /* if (fullName == null || dateOfBirth == null || placeOFBirth == null || passportNumber == null)
                throw new ArgumentNullException("Ошибка в конструкторе Person - аргументы не могут быть null");*/
            _fullName = fullName;
            _dateOfBirth = dateOfBirth;
            _placeOfBirth = passportNumber;
            _passportNumber = placeOFBirth;
        }

        public override string ToString()
        {
            return "ФИО: " + _fullName + " Дата Рождения: " + _dateOfBirth + 
                " Место рождения " + _placeOfBirth +" Номер паспорта: " + _passportNumber;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("#Equals error# - сравнение с null.");
            }

            if (!(obj is Person))
            {
                throw new ArgumentException("#Equals error# - Невозможное сравнение, объект не Person");
            }
            else
            {
                Person second = (Person)obj;
                return _fullName == second._fullName &&
                       _dateOfBirth == second._dateOfBirth &&
                       _placeOfBirth == second._placeOfBirth &&
                       _passportNumber == second._passportNumber;
            }
        }

        public static bool operator ==(Person first, Person second)
        {
            if (first == null || second == null)
            {
                throw new ArgumentNullException("#Operator '==' error# сравнение с null");
            }
            return first.Equals(second);
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }

        public override int GetHashCode()
        {
            return (_fullName + _dateOfBirth + _placeOfBirth + _passportNumber).GetHashCode();
        }
    }
}
