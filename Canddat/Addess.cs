namespace Canddat
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Flat { get; set; }

        public Address(string city, string street, int house, int flat) 
        {
                City = city;
                Street = street;
                House = house;
                Flat = flat;
        }

        public virtual string GetInfo() 
        {
            return $"{City} - {Street} - {House} - {Flat}";
        }
    }
}
