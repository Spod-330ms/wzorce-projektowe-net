using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09Decorator.Payments
{
    internal class CashPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Cash Payment done");
        }
    }
}
