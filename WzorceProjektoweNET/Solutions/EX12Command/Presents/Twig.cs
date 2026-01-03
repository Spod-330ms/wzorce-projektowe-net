using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12Command.Presents
{
    public class Twig : AbstractPresent
    {
        public Twig(string name, string type) : base(name, type)
        {
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"A Twig for a naughty kid. Name: {Name}, Type: {Type}");
        }
    }
}
