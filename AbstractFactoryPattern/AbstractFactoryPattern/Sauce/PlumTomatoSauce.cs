using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class PlumTomatoSauce : ISauce
    {
        public string toString()
        {
            return "Tomato sauce with plum tomatoes";
        }
    }
}
