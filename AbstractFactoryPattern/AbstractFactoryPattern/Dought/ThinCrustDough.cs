using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ThinCrustDough : IDough
    {
        public string toString()
        {
            return "Thin Crust Dough";

        }
    }
}
