using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Unversty_09._01._2023
{
    public class Rector : Employee
    {
        public string RectorDegree { get; set; }

        public Rector(string employeeName, string employeeDegree, string rectorDegree)
            : base(employeeName, employeeDegree)
        {
            RectorDegree = rectorDegree;
        }
        public string GetInfo() 
        {
            return RectorDegree;
        }
    }
}