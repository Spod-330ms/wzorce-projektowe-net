using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12Command
{
    public abstract class AbstractPresent
    {
        public string Name { get; private set; }
        public string Type { get; private set; }

        public AbstractPresent(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public abstract void DisplayInfo();
    }
}
