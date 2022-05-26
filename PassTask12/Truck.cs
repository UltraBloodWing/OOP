using System;

namespace TransportRegistry{
/// <summary>
/// class that creates car objects taht is inherited from Transport class
/// </summary>
    public class Truck:Transport{
        private double _weight;
        private int _numWheels;
/// <summary>
/// constructor for initializing the variables inhertited from the parent class
/// </summary>
/// <param name="plateNo"></param>
/// <param name="duration"></param>
/// <param name="rentalfee"></param>
/// <param name="rentable"></param>
/// <param name="weight"></param>
/// <param name="numWheels"></param>
/// <returns></returns>
        public Truck( string plateNo, int duration, int rentalfee, bool rentable, double weight, int numWheels):base(plateNo, duration, rentalfee, rentable){
            _weight = weight;
            _numWheels = numWheels;
        }
/// <summary>
/// Property to access weight
/// </summary>
/// <value></value>
        public double Weight{
            get{ return _weight; }
            set{ _weight = value; }
        }
/// <summary>
/// Property to access numWheels
/// </summary>
/// <value></value>
        public int NumWheels{
            get{ return _numWheels; }
            set{ _numWheels = value; }
        }
/// <summary>
/// function that overrides the parent class to Calculate rental fee and print weight if the rentalble is true
/// </summary>
/// <returns></returns>
        public override string RetrievedDetails(){
            if(base.Rentable == true){
                return "Plate No: " + base.PlateNo + "\nWeight: " + _weight + "\nRental Fee: " +  base.RentalFee + "\n** Drive with care! **";
            }
            else{
                return "** Truck rental service is not available at the moment **";
            }
        }
    }
}