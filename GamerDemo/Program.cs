using System;

namespace GamerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Customers
            Customer customer1 = new Customer { CustomerId = "baran44", TcNo = "111111111111", CustomerName = "Baran", CustomerLastName = "Dağdeviren", CustormerBirth = new DateTime(1993, 02, 05), BuyingData = 0 };
            Customer customer2 = new Customer { CustomerId = "legolas34", TcNo = "22222222222", CustomerName = "Hakan", CustomerLastName = "Kaba", CustormerBirth = new DateTime(1995, 10, 1), BuyingData = 5 };
            Customer customer3 = new Customer { CustomerId = "her636", TcNo = "3333333333", CustomerName = "Fikri", CustomerLastName = "Can", CustormerBirth = new DateTime(1994, 08, 21), BuyingData = 4 };
            Customer customer4 = new Customer { CustomerId = "phoneix", TcNo = "4444444444", CustomerName = "Barış", CustomerLastName = "Dağırcık", CustormerBirth = new DateTime(1991, 06, 03), BuyingData = 6 };
            Customer customer5 = new Customer { CustomerId = "gandalf354", TcNo = "555555555555", CustomerName = "Bahri", CustomerLastName = "Kaçık", CustormerBirth = new DateTime(1999, 03, 11), BuyingData = 13 };
            #endregion

            #region Products
            Product product1 = new Product { ProductId = 1, ProductName = "GTA 5", ProductType = "Free World", ProductPrice = 15.5, ProductYear = "2014", GameRating = 7.8 };
            Product product2 = new Product { ProductId = 1, ProductName = "Call Of Duty - Black Ops", ProductType = "Action", ProductPrice = 19.5, ProductYear = "2019", GameRating = 8.4 };
            #endregion


            Product[] products = new Product[] { product1, product2 };
            Customer[] custormers = new Customer[] { customer1, customer2, customer3 };

            ICampaignService campaign = new CampaignManager();
            CustomerManager gamerManager = new CustomerManager();


            foreach (var product in products)
            {
                gamerManager.ProductDiscount(product, customer1);
                gamerManager.ProductDiscount(product, customer2);
                gamerManager.ProductDiscount(product, customer3);
            }

        }
    }
}
