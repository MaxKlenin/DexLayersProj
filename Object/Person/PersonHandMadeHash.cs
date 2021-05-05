namespace Object.Person
{
    public class PersonHandMadeHash : Person
    {
        private readonly string _passportNumber;

        public PersonHandMadeHash(string fullName, string dateOfBirth, string placeOfBirth, string passportNumber)
            : base(fullName, dateOfBirth, placeOfBirth, passportNumber)
        {
            this._passportNumber = passportNumber;
        }

        public override int GetHashCode()
        {
            return 11111111;
        }
    }
}