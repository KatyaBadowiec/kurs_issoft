using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Class_6._01._2023
{
    internal class SupportStaff : University_Employee
    {
        public string Position { get; set;}
        public string Responsibilities { get; set;}

        public SupportStaff
            (Person person, 
            int taxId, 
            string position, 
            string responsibilities) 
            : base(person, taxId)

        {
        Position = position;
        Responsibilities= responsibilities;
        }

        public override string GetOficialDuties()     
        {
            return $"{Position} - {Responsibilities}";
        }
    }
}
