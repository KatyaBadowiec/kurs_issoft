using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unversty_09._01._2023
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeDegree { get; set; }

        public Employee(string employeeName, string employeeDegree)
        {
            EmployeeName = employeeName;
            EmployeeDegree = employeeDegree; 
        }
       
        public string GetInfo()
        {
            return EmployeeName + " " + EmployeeDegree;
        }
    }
}

