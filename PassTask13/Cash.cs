using System;

namespace PassTask13{
    public class Cash:Payment{
        /// <summary>
        /// constructor used to initialise the object
        /// </summary>
        /// <param name="amountToPay"></param>
        /// <param name="amountPaid"></param>
        /// <returns></returns>
        public Cash(double amountToPay,double amountPaid):base(amountToPay,amountPaid){
        }
        /// <summary>
        /// outputs balance
        /// </summary>
        public override void Display(){
            double balance = base.AmountPaid - base.AmountToPay;
            Console.WriteLine(balance);
        }
    }
}

