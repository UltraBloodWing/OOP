using System;
using System.Collections.Generic;

namespace PassTask13{
    
    public class Merchant{
        private string _username;
        private string _password;
        private List<Product> _products;
        private  List<Order> _orders;
        /// <summary>
        /// constructor to initialise the object
        /// </summary>
        public Merchant(){
            _products = new List<Product>();
            _orders = new List<Order>();
        }
        /// <summary>
        /// property to access the value of username
        /// </summary>
        /// <value></value>
        public string Username{
            get{ return _username; }
            set{ _username = value; }
        }
        /// <summary>
        /// merchant registration module
        /// </summary>
        public void Register(){
            Console.WriteLine("Enter Merchant Name: ");
            _username = Console.ReadLine();
            Console.WriteLine("Enter Merchant Password");
            _password = Console.ReadLine();
            Login();
        }
        /// <summary>
        /// merchant login system
        /// </summary>
        public void Login(){
           Console.WriteLine("Enter Merchant Name: ");
           string name = Console.ReadLine();
           Console.WriteLine("Enter Merchant Password: ");
           string password = Console.ReadLine();
           if(name == _username && password == _password){
               Console.WriteLine("Welcome Merchant");
           }
           else{
               if(name != _username){
                   Console.WriteLine("Invalid username, Please try again");
               }
               else{
                   Console.WriteLine("Invalid password, Please try again");
               }
               Login();
           }
        }
        /// <summary>
        /// adds a product to the list
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product){
            _products.Add(product);
        }
        /// <summary>
        /// removes a product from the list
        /// </summary>
        /// <param name="product"></param>
        public void RemoveProduct(Product product){
            _products.Remove(product);
        }
        /// <summary>
        /// edits a product 
        /// </summary>
        /// <param name="product"></param>
        public void EditProduct(Product product){
            product.EditProduct();
        } 
        public void ViewProduct(){
            foreach(Product product in _products){
                product.Display();
            }
        }             
        /// <summary>
        /// approval or rejection of the merchant order
        /// </summary>
        /// <param name="order"></param>
        public void OrderApproval(Order order){
                Console.WriteLine("Do you want to approve or reject the order? (y/n): ");
                string test = Console.ReadLine();
                if(test == "y"){
                    Console.WriteLine("Approved");
                    _orders.Add(order);
                }
                else if(test == "n"){
                    Console.WriteLine("Rejected");
                }
                else{
                    OrderApproval(order);
                }
        }
        /// <summary>
        /// property to access the products that the merchant sells
        /// </summary>
        /// <value></value>
        public List<Product> Products{
            get{ return _products; }
            set{ _products = value; }
        }
        /// <summary>
        /// displays the invoice of the order 
        /// </summary>
        /// <param name="order"></param>
        public void Invoice(Order order){
            foreach(Product product in order.Products){
                product.Display();
            }
        }
    }
}