using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace University_Class_6._01._2023
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
  
        public string GetInfo()
        {
            return FirstName +" "+ LastName;     
        } 
    }
}
