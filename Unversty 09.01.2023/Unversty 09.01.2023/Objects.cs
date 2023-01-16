using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unversty_09._01._2023
{
    public abstract class Objects
    {
        public string ObjectsProperty { get; set; }

        public Objects(string objectsProperty)
        {
            ObjectsProperty = objectsProperty;
        }

        public abstract string GetInfo();
    }
}

