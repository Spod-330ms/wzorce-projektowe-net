using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08Bridge
{
    public class WindowsSystem : ISystem
    {
        public void RunCommand(string command)
        {
            Console.WriteLine($"Running command on Windows: {command}");
            // Implementation for running command on Windows
        }
        public void ShowMenu()
        {
            Console.WriteLine("Displaying Windows system menu");
            // Implementation for displaying menu on Windows
        }
    }
}
