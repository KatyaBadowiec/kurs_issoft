using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unversty_09._01._2023
{
    internal class University
    {
        public string UniversityEmployee { get; set; }
        public string UniversityBuilding { get; set; }
        public string Rector { get; set; }

        public University(string universityEmployee, string universityBuilding, string rector)
        {
            UniversityEmployee = universityEmployee;
            UniversityBuilding = universityBuilding;
            Rector = rector;
        }

        public virtual string GetOficialDuties()
        {
            return "";
        }
    }
}