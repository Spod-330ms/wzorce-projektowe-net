using EX09Decorator;
using EX09Decorator.Payments;

Shop shop = new Shop();

shop.ProcessPayment(new CashPayment(), 50m);
shop.ProcessPayment(new TransferPayment(), 200m);
shop.ProcessPayment(new CardPayment(), 100m);

