namespace UniversityProject
{
    public class Room : UniversityEntity
    {
        public string Assignment { get; set; }
        public int RoomNumber { get; set; }

        public Room(string assigment, int roomNamber)
        {
            Assignment = assigment;
            RoomNumber = roomNamber;
        }

        public override string GetInfo()
        {
            return $"Room. Assignment: {Assignment}, number: {RoomNumber}";
        }
    }
}

 
