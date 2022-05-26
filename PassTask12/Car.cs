using System;

namespace TransportRegistry{
/// <summary>
/// class that creates car objects taht is inherited from Transport class
/// </summary>
    public class Car:Transport{
        private int _noOfSeats;
/// <summary>
/// constructor for initializing the variables inhertited from the parent class
/// </summary>
/// <param name="plateNo"></param>
/// <param name="duration"></param>
/// <param name="rentalfee"></param>
/// <param name="rentable"></param>
/// <param name="noOfSeats"></param>
/// <returns></returns>//
        public Car( string plateNo, int duration, int rentalfee, bool rentable, int noOfSeats):base(plateNo, duration, rentalfee, rentable){
            _noOfSeats = noOfSeats;
        }
/// <summary>
/// function that overrides the parent class to retrieve details
/// </summary>
/// <returns></returns>
        public override string RetrievedDetails(){
            return "Plate No: " + base.PlateNo + "\nRental Fee: " + base.RentalFee + "\n** You have a good deal on this **";
        }
    }
}