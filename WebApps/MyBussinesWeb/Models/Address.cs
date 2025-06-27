namespace MyBussinessWeb.Models
{
    public class Address(string FirstName, string LastName, string EmailAddress, string AddressLine)
    {
        public readonly string FirstName = FirstName;
        public readonly string LastName = LastName;
        public readonly string EmailAddress = EmailAddress;
        public readonly string AddressLine = AddressLine;
    }
}
