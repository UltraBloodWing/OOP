using System;
using System.Collections.Generic;

namespace PassTask13{
   
    public class Order{
        private List<Product> _products;
        
        /// <summary>
        /// constructor used to initialise the value to the object
        /// </summary>
        public Order(){
            _products = new List<Product>();
        }
        /// <summary>
        /// property to access the pproducts list
        /// </summary>
        /// <value></value>
        public List<Product> Products{
            get{ return _products; }
            set{ _products = value; }
        }
        /// <summary>
        /// adds a product int he list
        /// </summary>
        /// <param name="p"></param>
        public void AddProduct(Product p){
            _products.Add(p);
        }
        /// <summary>
        /// removes a product from th e list
        /// </summary>
        /// <param name="p"></param>
        public void RemoveProduct(Product p){
            _products.Remove(p);
        }  
        /// <summary>
        /// returns total price of the order 
        /// </summary>
        /// <returns></returns>
        public double CalculateTotalPrice(){
            double total = 0;
            foreach (Product product in _products){
                total = total + product.CalcUnitPrice();
            }
            return total;
        } 
    }
}