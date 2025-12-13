using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08Bridge
{
    public class LinuxSystem : ISystem
    {
        public void RunCommand(string command)
        {
            Console.WriteLine($"Running command on Linux: {command}");
            // Implementation for running command on Linux
        }
        public void ShowMenu()
        {
            Console.WriteLine("Displaying Linux system menu");
            // Implementation for displaying menu on Linux
        }
    }
}
