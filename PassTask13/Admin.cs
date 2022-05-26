 using System;

namespace PassTask13{
    
    public class Admin{
        private string _username;
        private string _password;
        /// <summary>
        /// constructor to initialise the object
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public Admin(string username, string password){
            _username = username;
            _password = password;
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
        /// login module for the admin
        /// </summary>
        public void Login(){
           Console.WriteLine("Enter Admin Name: ");
           string name = Console.ReadLine();
           Console.WriteLine("Enter Admin Password: ");
           string password = Console.ReadLine();
           if(name == _username && password == _password){
               Console.WriteLine("Welcome Admin");
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
        /// shows the products sold by the merchant
        /// </summary>
        /// <param name="merchant"></param>
        public void CheckProductSoldByMerchant(Merchant merchant){
            foreach (Product product in merchant.Products){
                product.Display();
            }
        }
        /// <summary>
        /// shows customer profile
        /// </summary>
        /// <param name="customer"></param>
        public void CustomerProfile(Customer customer){
            Console.WriteLine("Customer Name: " + customer.Username);
        }
    }
}