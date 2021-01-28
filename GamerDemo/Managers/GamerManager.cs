using System;
using System.Collections.Generic;
using System.Text;

namespace GamerDemo
{
    class GamerManager
    {


        public void ProductDiscount(Product product, Customer customer)
        {
            if (customer.BuyingData == 0)
            {
                int discountRate = 25;
                double newPrice = (double)(product.ProductPrice - product.ProductPrice * 0.25);
                Console.WriteLine("Sayın " + customer.CustomerId + "\n" +
                    "Oyun adı : " + product.ProductName + "\n" + "Size özel indirimimiz :" + newPrice 
                    );
                Console.WriteLine("\n"+"******************************************");
            }

            else if (customer.BuyingData > 0 & customer.BuyingData < 5)
            {
                int discountRate = 20;
                double newPrice = (double)(product.ProductPrice - product.ProductPrice * 0.2);
                Console.WriteLine("Sayın " + customer.CustomerId + "\n" +
                    "Oyun adı : " + product.ProductName + "\n" + "Size özel indirimimiz :" + newPrice
                    );
                Console.WriteLine("\n" + "******************************************");
            }

            else if (customer.BuyingData > 5 & customer.BuyingData < 10)
            {
                int discountRate = 15;
                double newPrice = (double)(product.ProductPrice - product.ProductPrice * 0.15);
                Console.WriteLine("Sayın " + customer.CustomerId + "\n" +
                    "Oyun adı : " + product.ProductName + "\n" + "Size özel indirimimiz :" + newPrice
                    );
                Console.WriteLine("\n" + "******************************************");
            }

            else if (customer.BuyingData > 10)
            {
                int discountRate = 10;
                double newPrice = (double)(product.ProductPrice - product.ProductPrice * 0.10);
                Console.WriteLine("Sayın " + customer.CustomerId + "\n" +
                    "Oyun adı : " + product.ProductName + "\n" + "Size özel indirimimiz :" + newPrice
                    );
                Console.WriteLine("\n" + "******************************************");
            }
        }
    }
}
