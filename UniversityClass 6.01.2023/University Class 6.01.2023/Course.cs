using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Class_6._01._2023
{
    internal class Course
    {
        public string CourseName { get; set; }
        public string DescriptionCourse { get; set; }

        public Course (string courseName, string descriptionCourse)
        {
            CourseName = courseName;
            DescriptionCourse = descriptionCourse;   
        }
    }
}
