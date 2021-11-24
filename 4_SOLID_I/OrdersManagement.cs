using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_SOLID_I.Good
{
    internal interface IOrder
    {
        void AddToCart(string item);
    }

    internal interface IOnlineOrder
    {
        void CreditCardProcessPayment();
    }

    internal class OnlineOrder : IOrder, IOnlineOrder
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
    }

}
