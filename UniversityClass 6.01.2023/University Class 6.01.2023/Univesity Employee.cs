using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Class_6._01._2023
{
    internal class University_Employee
    {
        public Person PersonalData{ get; set; }
        public int TaxID { get; set; }

        public University_Employee(Person person, int taxID) 
        {
            PersonalData = person;
            TaxID = taxID;
        }

        public virtual string GetOficialDuties()
        {
            return "";  // "neponiatno kakie obiazannosti";     
        }
    }
}
