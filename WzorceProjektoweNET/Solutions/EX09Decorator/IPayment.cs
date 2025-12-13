using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09Decorator
{
    internal interface IPayment
    {
        void Pay(decimal amount);
    }
}
