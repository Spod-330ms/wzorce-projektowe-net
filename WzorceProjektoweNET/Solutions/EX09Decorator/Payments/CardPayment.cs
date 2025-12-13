using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09Decorator.Payments
{
    internal class CardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Card Payment done");
        }
    }
}
