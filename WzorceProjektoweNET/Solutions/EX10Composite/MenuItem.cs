using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EX10Composite
{
    public abstract class MenuItem
    {
        internal string Name { get; }
        private List<MenuItem> _menuItems = new List<MenuItem>();
        internal int Level { get; private set; } = 0;
        public MenuItem(string name)
        {
            Name = name;
        }

        public abstract void DisplayName();
        public abstract bool IsComposite();

        public void AddMenuItem(MenuItem menuItem)
        {
            if(this.IsComposite() == false)
            {
                throw new InvalidOperationException("Cannot add menu items to a non-composite menu item.");
            }
            menuItem.SetLevel(this.Level + 1);
            _menuItems.Add(menuItem);
        }
        public void RemoveMenuItem(MenuItem menuItem)
        {
            if (this.IsComposite() == false)
            {
                throw new InvalidOperationException("Cannot remove menu items to a non-composite menu item.");
            }
            _menuItems.Remove(menuItem);
        }

        public List<MenuItem> GetMenuItems()
        {
            if (this.IsComposite() == false)
            {
                throw new InvalidOperationException("Cannot get menu items from a non-composite menu item.");
            }

            return this._menuItems;
        }

        internal void SetLevel(int level)
        {
            Level = level;
            foreach(var menuItem in _menuItems)
            {
                menuItem.SetLevel(level + 1);
            }
        }
    }
}
