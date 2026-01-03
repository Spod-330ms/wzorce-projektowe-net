using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10Composite
{
    public class MenuCategoryComposite : MenuItem
    {

        public MenuCategoryComposite(string name) : base(name)
        {
        }

        public override void DisplayName()
        {
            string dash = new string('+', this.Level);
            Console.WriteLine(dash + " " + this.Name);
            foreach (var menuItem in this.GetMenuItems())
            {
                menuItem.DisplayName();
            }
        }
        public override bool IsComposite()
        {
            return true;
        }
    }
}
