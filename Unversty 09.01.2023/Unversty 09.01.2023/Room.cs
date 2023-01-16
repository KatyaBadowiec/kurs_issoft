using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unversty_09._01._2023
{
    public class Room
    {
        public string Assignment { get; set; }
        public int RoomNumber { get; set; }

        public Room(string assigment, int roomNamber)
        {
            Assignment = assigment;
            RoomNumber = roomNamber;
        }
        public string GetInfo()
        {
            return Assignment + " " + RoomNumber;
        }
    }
}

 
