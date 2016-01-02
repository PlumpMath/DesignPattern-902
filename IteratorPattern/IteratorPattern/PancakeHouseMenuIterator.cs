using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IteratorPattern
{
    public class PancakeHouseMenuIterator : Iterator
    {
        List<MenuItem> items = new List<MenuItem>();
        int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public object next()
        {
            MenuItem item = items[position];
            position = position + 1;
            return item;
        }

        public bool hasNext()
        {
            if (position >= items.Count())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
