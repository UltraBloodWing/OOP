using System;

namespace TransportRegistry{
/// <summary>
/// class that creates car objects taht is inherited from Transport class
/// </summary>    
    public class Motorbike:Transport{
        private int _cylinderCap;
        private int _baseTax;
/// <summary>
/// constructor for initializing the variables inhertited from the parent class
/// </summary>
/// <param name="plateNo"></param>
/// <param name="duration"></param>
/// <param name="rentalfee"></param>
/// <param name="rentable"></param>
/// <param name="cylinderCap"></param>
/// <returns></returns>
        public Motorbike( string plateNo, int duration, int rentalfee, bool rentable, int cylinderCap):base(plateNo, duration, rentalfee, rentable){
            _cylinderCap = cylinderCap;
            _baseTax = 50;
        }
/// <summary>
/// function that overrides the parent class to Calculate rental fee and add base tax
/// </summary>
/// <returns></returns>
        public override int CalculateRentalFee(){
            return (base.RentalFee * base.Duration) + _baseTax;
        }
/// <summary>
/// function that overrides the parent class to retrieve details
/// </summary>
/// <returns></returns>
        public override string RetrievedDetails(){
            return "Plate No: " + base.PlateNo + "\nRental Fee: " + base.RentalFee + "\n** The two wheels transport is faster than you expected **";
        }
/// <summary>
/// property to access Base Tax
/// </summary>
/// <value></value>
        public int BaseTax{
            set{ _baseTax = value; }
        }
/// <summary>
/// property to access Cylinder Cap
/// </summary>
/// <value></value>
        public int CylinderCap{
            get{ return _cylinderCap; }
            set{ _cylinderCap = value; }
        }

    }
}