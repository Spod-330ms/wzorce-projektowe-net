using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09Decorator.Payments
{
    internal class TransferPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Transfer Payment done");
        }
    }
}
