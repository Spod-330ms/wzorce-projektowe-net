using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08Bridge
{
    public abstract class AbstractInterface
    {
        protected ISystem _system;
        public AbstractInterface(ISystem system)
        {
            this._system = system;
        }

        public abstract void displayMenu();

        protected void ShowSystemMenu()
        {
            _system.ShowMenu();
        }
    }
}
