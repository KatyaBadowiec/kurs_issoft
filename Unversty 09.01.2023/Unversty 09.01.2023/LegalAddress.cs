using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unversty_09._01._2023;

namespace Unversty_09._01._2023
{
    internal class LegalAddress
    {
        public string LegalUniversityAddress { get; set; }

        public LegalAddress(string legalUniversityAddress)
        {
            LegalUniversityAddress = legalUniversityAddress;
        }
        public string GetInfo()
        {
            return LegalUniversityAddress;
        }
    }
}