namespace Object.Person
{
    public class PersonHandMadeHash : Person
    {
        public PersonHandMadeHash(string _fullName, string _dateOfBirth, string _placeOfBirth, string _passportNumber)
            : base(_fullName, _dateOfBirth, _placeOfBirth, _passportNumber)
        {
        }
        public override int GetHashCode()
        {
            return 11111111;
        }
    }
}