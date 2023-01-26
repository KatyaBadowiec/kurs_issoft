namespace UniversityProject
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }

        public Address(string city, string street, int house)
        {
            City = city;
            Street = street;
            House = house;
        }

        public string GetInfo()
        {
            return $"City: {City}, street: {Street}, house: {House}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Address other = obj as Address;

            if (this.City != other.City)
                return false;
            if (this.Street != other.Street)
                return false;
            if (this.House != other.House)
                return false;

            return true;
        }
    }
}
