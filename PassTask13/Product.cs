using System;

namespace PassTask13{
    
    public class Product{
        private string _name;
        private int _quantity;
        private double _price;
        private Type _type;
        /// <summary>
        /// constructor to initialise the values to the object 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        /// <param name="type"></param>
        public Product(string name, int quantity, double price, Type type){
            _name = name;
            _quantity = quantity;
            _price = price;
            _type = type;
        }
        /// <summary>
        /// property to get acces to the name 
        /// </summary>
        /// <value></value>
        public string Name{
            get{ return _name; }
            set{ _name =value; }
        }
        /// <summary>
        /// property to access the value of the quantity
        /// </summary>
        /// <value></value>
        public int Quantity{
            get{ return _quantity; }
            set{ _quantity =value; }
        }
        /// <summary>
        /// property to access the value of the price
        /// </summary>
        /// <value></value>
        public double Price{
            get{ return _price; }
            set{ _price = value; }
        }
        public double CalcUnitPrice(){
            double unitPrice = _quantity * _price;
            return unitPrice;
        }
        /// <summary>
        /// edits a product based on user provided values
        /// </summary>
        public void EditProduct(){
            Console.WriteLine("Enter the name: ");
            _name = Console.ReadLine();
            Console.WriteLine("Enter the quantity: ");
            _quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price: ");
            _price = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// prints out the product values
        /// </summary>
        public void Display(){
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Quantity " + _quantity);
            Console.WriteLine("Price: " + _price);
        }
    }
}