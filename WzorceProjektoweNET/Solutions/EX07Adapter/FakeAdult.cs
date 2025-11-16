using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07Adapter
{
    public class FakeAdult : Adult
    {
        public new bool IsAdult(int age)
        {
            // In this fake implementation, we consider everyone as an adult
            return true;
        }
    }
}
