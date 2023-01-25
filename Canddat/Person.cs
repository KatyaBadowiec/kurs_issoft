namespace Canddat
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public Person(string firstName, string lastName, Address adress)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = adress;
        }
        
        public string GetInfo()
        {
            return $"{FirstName} - {LastName} - {Address}";
        }
    }
}