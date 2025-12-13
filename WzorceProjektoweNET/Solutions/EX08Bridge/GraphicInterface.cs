using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08Bridge
{
    internal class GraphicInterface : AbstractInterface
    {
        public GraphicInterface(ISystem system) : base(system)
        {
        }

        public override void displayMenu()
        {
            Console.WriteLine("Displaying graphical interface menu");
            this.ShowSystemMenu();
            // Implementation for displaying graphical menu
        }
    }
}
