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

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj is not Building other)
            {
                return false;
            }

            if (!BuldingAddress.Equals(other.BuldingAddress))
                return false;

            if (Rooms.Count != other.Rooms.Count)
                return false;

            foreach (var room in Rooms)
            {
                if (!other.Rooms.Contains(room))
                    return false;
            }
            return true;
        }
    }
}

