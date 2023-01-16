using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unversty_09._01._2023
{
    internal class Address
    {
        public string ObjectAddress { get; set; }

        public Address(string objectAddress) 
        {
            ObjectAddress = objectAddress;
        }
        public string GetInfo() 
        {
            return ObjectAddress;
        }  
    }
}
