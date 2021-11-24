using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_SOLID_I
{
    internal interface IOrder
    {
        void AddToCart(string item);
        void CreditCardProcessPayment();
    }

    internal class OnlineOrder : IOrder
    {
        public void AddToCart(string item)
        {
            Console.WriteLine($"Magnanimus code to add the item {item} to the cart");
        }

        public void CreditCardProcessPayment()
        {
            Console.WriteLine("Extremely wonderful code to process the payment through a credit card");
        }
    }

    internal class OfflineOrder : IOrder
    {
        public void AddToCart(string item)
        {
            Console.WriteLine($"Magnanimus code to add the item {item} to the cart");
        }

        public void CreditCardProcessPayment()
        {
            throw new NotImplementedException("This can't be done for offline orders!!!");
        }
    }
}
