using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ThickCrustDough : IDough
    {
        public string toString()
        {
            return "ThickCrust style extra thick crust dough";

        }
    }
}
