using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class MarinaraSauce:ISauce
    {
        public string toString()
        {
            return "Marinara Sauce";
        }
    }
}
