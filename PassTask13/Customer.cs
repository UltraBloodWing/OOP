using System;

namespace PassTask13{
    
    public class Customer{
        private string _username;
        private string _password;
        public string Username{
            get{ return _username; }
            set{ _username = value; }
        }       
        /// <summary>
        /// method used to register customer 
        /// </summary>
        public void Register(){
            Console.WriteLine("Enter Customer Name: ");
            _username = Console.ReadLine();
            Console.WriteLine("Enter Customer Password");
            _password = Console.ReadLine();
            Login();
        }          
        /// <summary>
        /// method used to login
        /// </summary>
        public void Login(){
            Console.WriteLine("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Customer Password: ");
            string password = Console.ReadLine();
            if(name == _username && password == _password){
                Console.WriteLine("Welcome Customer");
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
        /// brose products from the merchant product list
        /// </summary>
        /// <param name="merchant"></param>
        public void BrowseProducts(Merchant merchant){
            Order order = new Order();
            Console.WriteLine("How many Products do you want to add to cart: ");
            int noOfProducts = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < noOfProducts; i++){
                Console.WriteLine("\n Enter Name of the product: ");
                string productName = Console.ReadLine();
                foreach(Product product in merchant.Products){
                    if(product.Name == productName){
                        Console.WriteLine("Product added to cart");
                        order.AddProduct(product);
                    }
                    else{
                        Console.WriteLine("This Merchant does not have this specific product");
                    }
                }         
            }    
        }  
        /// <summary>
        /// customer feedback
        /// </summary>
        public void RatingProducts(){
            Console.WriteLine("Please provide feedback based on 5 rating stars ");
            int noOfStars = Convert.ToInt32(Console.ReadLine());
            if(noOfStars == 1){
                Console.WriteLine("Very Dissatisfied");
            }
            else if(noOfStars == 2){
                Console.WriteLine("Dissatisfied");
            }
            else if(noOfStars == 3){
                Console.WriteLine("Normal");
            }
            else if(noOfStars == 4){
                Console.WriteLine("Satisfied");
            }
            else if(noOfStars == 5){
                Console.WriteLine("Very Satisfied");
            }
            else{
                Console.WriteLine("Please enter a number between 0 and 6");
                RatingProducts();
            }
            Console.WriteLine("Thank you for your honest response, have a great day");
        }
    }
}