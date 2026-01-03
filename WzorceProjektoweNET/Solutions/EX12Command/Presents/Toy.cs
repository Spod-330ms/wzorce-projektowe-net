using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12Command.Presents
{
    public class Toy : AbstractPresent
    {
        public Toy(string name, string type) : base(name, type)
        {
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"A Toy for a good kid. Name: {Name}, Type: {Type}");
        }
    }
}
