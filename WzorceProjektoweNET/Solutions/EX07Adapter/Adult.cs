using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07Adapter
{
    public class Adult
    {
        public bool IsAdult(int age)
        {
            return age >= 18;
        }
    }
}
