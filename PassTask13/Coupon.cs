using System;

namespace PassTask13{
    
    public class Coupon:Payment{
        private double _discount;
        /// <summary>
        /// constructor used to initialise the valueto the objecdt
        /// </summary>
        /// <param name="amountToBePaid"></param>
        /// <param name="amountPaid"></param>
        /// <param name="discount"></param>
        /// <returns></returns>
        public Coupon(double amountToBePaid,double amountPaid, double discount):base(amountToBePaid,amountPaid){
            _discount = discount;
        }
        /// <summary>
        /// prints balance
        /// </summary>
        public override void Display(){
            double discount = base.AmountToPay * _discount/100;
            double lowerCost = base.AmountToPay - discount;
            double balance = base.AmountPaid - lowerCost;
            Console.WriteLine(balance);
        }
    }
}