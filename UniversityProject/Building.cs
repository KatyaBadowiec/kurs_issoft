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
            Building other = obj as Building;

            if (!this.BuldingAddress.Equals(other.BuldingAddress))
                return false;

            if (this.Rooms.Count != other.Rooms.Count)
                return false;

            foreach (var room in Rooms)
            {
                bool sameRoomFound = false;
                foreach (var roomOther in other.Rooms)
                {
                    if (room.Assignment == roomOther.Assignment &&
                        room.RoomNumber == roomOther.RoomNumber)
                    {
                        sameRoomFound = true;
                        break;
                    }
                }

                if (!sameRoomFound)
                    return false;
            }

            return true;
        }
    }
}
