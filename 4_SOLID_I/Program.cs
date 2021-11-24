// See https://aka.ms/new-console-template for more information
using _4_SOLID_I;

Console.WriteLine("Hello, World!");

OnlineOrder onlineOrderNotSolid = new OnlineOrder();
onlineOrderNotSolid.AddToCart("iphone 20 Turbo Pro");
onlineOrderNotSolid.CreditCardProcessPayment();

OfflineOrder offlineOrderNotSolid = new OfflineOrder();
offlineOrderNotSolid.AddToCart("galaxy z fold 5");
//no deberíamos llamar a este método, ya que nos devolvería una excepción porq una orden offline no puede procesar pago
//por tarjeta de crédito. Podríamo meter un trycatch, pero ahora le daríamos a Program.cs la responsabilidad de encargarse de los errores.
try
{
    offlineOrderNotSolid.CreditCardProcessPayment();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("Ahora vamos a hacerlo bien");

_4_SOLID_I.Good.OnlineOrder onlineOrder = new _4_SOLID_I.Good.OnlineOrder();
onlineOrder.AddToCart("iphone 20 turbo Pro");
onlineOrder.CreditCardProcessPayment();

_4_SOLID_I.Good.OfflineOrder offlineOrder = new _4_SOLID_I.Good.OfflineOrder();
offlineOrder.AddToCart("galaxy z fold 5");