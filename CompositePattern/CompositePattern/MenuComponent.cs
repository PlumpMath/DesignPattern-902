using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new Exception();
        }
        public virtual void Removed(MenuComponent menuComponent)
        {
            throw new Exception();
        }
        public virtual void getChild(int i)
        {
            throw new Exception();
        }

        public virtual string getName()
        {
            throw new Exception();
        }
        public virtual string getDescription()
        {
            throw new Exception();
        }
        public virtual double getPrice()
        {
            throw new Exception();
        }
        public virtual bool isVegetarian()
        {
            throw new Exception();
        }

        public virtual void print()
        {
            throw new Exception();
        }
    }
}
