using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08Bridge
{
    public class ConsoleInterface : AbstractInterface
    {
        public ConsoleInterface(ISystem system) : base(system)
        {
        }

        public override void displayMenu()
        {
            Console.WriteLine("Displaying console interface menu");
            this.ShowSystemMenu();
            // Implementation for displaying console menu
        }
    }
}
