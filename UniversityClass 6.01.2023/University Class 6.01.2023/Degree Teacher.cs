using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Class_6._01._2023
{
    internal class Degree_Teacher : Teacher
    {
        public string AcademicDegree { get; set; }
        public string AcademicTitle { get; set; }

        public Degree_Teacher(string academicDegree, string academicTitle, Person person, int taxId, Course course) 
            : base (person, taxId, course)
        {
        AcademicDegree = academicDegree;
        AcademicTitle = academicTitle;
        }

        public override string GetOficialDuties()
        {
            return   AcademicDegree + " " + AcademicTitle;    
        }
    }
}
