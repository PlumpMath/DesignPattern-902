using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Menu:MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        string name;
        string description;

        public Menu(string name,string description)
        {
            this.name=name;
            this.description=description;
        }
        public override void Add(MenuComponent menuComponent)
        {
            menuComponent.Add(menuComponent);
        }
        public override void Removed(MenuComponent menuComponent)
        {
            menuComponent.Removed(menuComponent);
        }
    }
}
