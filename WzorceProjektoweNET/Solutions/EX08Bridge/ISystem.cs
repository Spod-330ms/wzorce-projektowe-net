using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08Bridge
{
    public interface ISystem
    {
        void ShowMenu();
        void RunCommand(string command);
    }
}
