using System;

namespace PassTask13
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("Masrur","admin");
            admin.Login();
            Customer customer = new Customer();
            customer.Register();
            Merchant merchant = new Merchant();
            merchant.Register();
            
            Order order = new Order();
            Product[] products = new Product[3];
            products[0] = new Product("Shirt", 3, 20, Type.Fashion);
            products[1] = new Product("TV", 1, 120, Type.Electronics);
            products[2] = new Product("Pizza", 2, 30, Type.Foods);
            foreach(Product product in products){
                order.AddProduct(product);
            }
        }
    }
}
