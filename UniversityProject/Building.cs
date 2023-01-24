namespace UniversityProject
{
    public class Building : UniversityEntity
    {
        public Address BuldingAddress { get; set; }
        public List<Room> Rooms { get; set; }

        public Building(Address address, List<Room> rooms)
        {
            BuldingAddress = address;
            Rooms = rooms;
        }

        public override string GetInfo()
        {
            return $"Building. {BuldingAddress.GetInfo()}";
        }
    }   
}
