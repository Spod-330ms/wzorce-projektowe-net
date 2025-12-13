using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09Decorator
{
    internal class CardPaymentDecorator : IPayment
    {
        private readonly IPayment _basePayment;
        public CardPaymentDecorator(IPayment basePayment)
        {
            _basePayment = basePayment;
        }
        public void Pay(decimal amount)
        {
            this._basePayment.Pay(amount);
            this.TextMessageNotification();
            this.AddLoyaltyPoints();
            this.RedirectToMainPage();
        }

        private void TextMessageNotification()
        {
            Console.WriteLine("Sending text message notification for card payment.");
        }
        private void AddLoyaltyPoints()
        {
            Console.WriteLine("Adding loyalty points for card payment.");
        }
        private void RedirectToMainPage()
        {
            Console.WriteLine("Redirecting to main page after card payment.");
        }
    }
}
