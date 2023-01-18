using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Class_6._01._2023
{
    internal class University_Employee
    {
        public Person PersonalData { get; set; }

        private int _taxId;
        public int TaxId 
        { 
            get 
            { 
                return _taxId; 
            }
            set 
            { 
                if (value > 0) 
                { 
                    _taxId = value; 
                } 
            }
        }

        public University_Employee(Person person, int taxId)
        {
            PersonalData = person;
            TaxId = taxId;
        }

        public virtual string GetOficialDuties()
        {
            return "";
        }
    }
}
