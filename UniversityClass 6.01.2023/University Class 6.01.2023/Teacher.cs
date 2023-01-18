using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Class_6._01._2023
{
    internal class Teacher : University_Employee
    {
        public Course TeacherCourse { get; set; }

        public Teacher(Person person, int taxId, Course course)
            : base(person, taxId)
        {
            TeacherCourse = course;
        }

        public override string GetOficialDuties()     
        {
            return $"Teaching {TeacherCourse.CourseName} ({TeacherCourse.DescriptionCourse})";
        }
    }
}
    