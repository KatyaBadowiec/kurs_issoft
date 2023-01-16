using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unversty_09._01._2023
{
    public class Building : Objects
    {
        public string Address { get; set; }
        public Room Rooms { get; set; }

        public Building(string address, Room rooms)
            : base("building")
        {
            Address = address;
            Rooms = rooms;
           // LegalAddress = legalAddress;
        }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }   
}
