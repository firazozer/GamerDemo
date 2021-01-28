using System;

namespace GamerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                //CustomerId kullanıcı adı olarak kullandım TcNo hali hazırda ID olarak kullanmak için.
                CustomerId = "baran44",
                TcNo = "111111111111",
                CustomerName = "Baran",
                CustomerLastName = "Dağdeviren",
                CustormerBirth = 1995,
                BuyingData = 0

            };

            Customer customer2 = new Customer
            {
                //CustomerId kullanıcı adı olarak kullandım TcNo hali hazırda ID olarak kullanmak için.
                CustomerId = "legolas34",
                TcNo = "22222222222",
                CustomerName = "Fikri",
                CustomerLastName = "Sağlar",
                CustormerBirth = 1995,
                BuyingData = 8
            };

            Customer customer3 = new Customer
            {
                //CustomerId kullanıcı adı olarak kullandım TcNo hali hazırda ID olarak kullanmak için.
                CustomerId = "black734",
                TcNo = "3333333333",
                CustomerName = "Firaz",
                CustomerLastName = "Demir",
                CustormerBirth = 1997,
                BuyingData = 13
            };

            Product product1 = new Product
            {
                ProductId = 1,
                ProductName = "GTA 5",
                ProductType = "Free World",
                ProductPrice = 15.5,
                ProductYear = "2014",
                GameRating = 7.8


            };
            Product product2 = new Product
            {
                ProductId = 1,
                ProductName = "Call Of Duty - Black Ops",
                ProductType = "Action",
                ProductPrice = 19.5,
                ProductYear = "2019",
                GameRating = 8.4


            };

            Product[] products = new Product[] { product1, product2 };
            Customer[] custormers = new Customer[] { customer1, customer2, customer3 };

            ICampaignService campaign = new CampaignManager();
            GamerManager gamerManager = new GamerManager();


            foreach (var product in products)
            {
                gamerManager.ProductDiscount(product, customer1);
                gamerManager.ProductDiscount(product, customer2);
                gamerManager.ProductDiscount(product, customer3);
            }

        }
    }
}
