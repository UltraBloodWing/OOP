using System;

namespace PassTask13{
    
    public abstract class Payment{
        private double _amountToPay;
        private double _amountPaid;
        /// <summary>
        /// constructor used to initialsise the values to the object
        /// </summary>
        /// <param name="amountToPay"></param>
        /// <param name="amountPaid"></param>
        public Payment(double amountToPay,double amountPaid){
            _amountToPay = amountToPay;
            _amountToPay = amountPaid;
        }
        /// <summary>
        /// property for child classes to use 
        /// </summary>
        /// <value></value>
        public double AmountPaid{
            get{ return _amountPaid; }
            set{ _amountPaid = value; }
        }
        /// <summary>
        /// property for child classes to use 
        /// </summary>
        /// <value></value>
        public double AmountToPay{
            get{ return _amountToPay; }
            set{ _amountToPay = value; }
        }
        /// <summary>
        /// abstract function, continues in child classes
        /// </summary>
        public abstract void Display();
    }
}