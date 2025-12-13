using EX09Decorator.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09Decorator
{
    enum PaymentType
    {
        Card,
        Cash,
        Transfer

    }
    internal class Shop
    {
        public void ProcessPayment(IPayment paymentMethod, decimal amount)
        {
            IPayment _paymentMethod = null;
            if (paymentMethod.GetType() == typeof(CardPayment))
            {
                _paymentMethod = new CardPaymentDecorator(paymentMethod);
            }
            else
            {
                _paymentMethod = paymentMethod;
            }
            _paymentMethod.Pay(amount);
        }
    }
}
