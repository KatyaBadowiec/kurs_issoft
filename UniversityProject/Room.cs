namespace UniversityProject
{
    public class Room : UniversityEntity
    {
        public string Assignment { get; set; }
        public int RoomNumber { get; set; }

        public Room(string assigment, int roomNumber)
        {
            Assignment = assigment;
            RoomNumber = roomNumber;
        }

        public override string GetInfo()
        {
            return $"Room. Assignment: {Assignment}, number: {RoomNumber}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            
            if (obj is Room other)
            {
                if (Assignment != other.Assignment || RoomNumber != other.RoomNumber)
                    return false;
                    return true;
            }
            return false;
        }
    } 
}

 
