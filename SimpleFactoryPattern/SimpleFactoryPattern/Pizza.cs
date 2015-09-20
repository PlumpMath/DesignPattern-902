using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public abstract class Pizza
    {
        public abstract void prepare();
        public abstract void bake();
        public abstract void cut();
        public abstract void box();
    }
}
