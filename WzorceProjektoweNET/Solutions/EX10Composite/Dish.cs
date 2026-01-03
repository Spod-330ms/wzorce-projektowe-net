using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10Composite
{
    public class Dish : MenuItem
    {
        private double _price;
        public Dish(string name, double price) : base(name)
        {
            _price = price;
        }

        public override void DisplayName()
        {
            //Display the dish name along with its price and a dash responding to level
            string dash = new string('-', this.Level);
            Console.WriteLine(dash + " " + this.Name + " - $" + _price);
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
