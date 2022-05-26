using System;

namespace TransportRegistry{
/// <summary>
/// this is a template to create object for the transport class
/// </summary>
    public class Transport{
        private string _plateNo;
        private int _duration;
        private int _rentalfee;
        private bool _rentable;
        private TransportType _type;
/// <summary>
/// this is used to initialize the object
/// </summary>
/// <param name="plateNo"></param>
/// <param name="duration"></param>
/// <param name="rentalfee"></param>
/// <param name="rentable"></param>
/// <param name="type"></param>
        public Transport( string plateNo, int duration, int rentalfee, bool rentable, TransportType type){
            _plateNo = plateNo;
            _duration = duration;
            _rentalfee = rentalfee;
            _rentable = rentable;
            _type = type;
        }
/// <summary>
/// property to acess Plate number of the ojb
/// </summary>
/// <value></value>
        public string PlateNo{
            get { return _plateNo; }
            set { _plateNo = value; }
        }
/// <summary>
/// property to acess Duration of rental of the ojb
/// </summary>
/// <value></value>
        public int Duration{
            get { return _duration; }
            set { _duration = value; }
        }
/// <summary>
/// property to acess Rental fee of the ojb
/// </summary>
/// <value></value>
        public int RentalFee{
            get { return _rentalfee; }
            set { _rentalfee = value; }
        }
/// <summary>
/// property to acess rentable of the ojb
/// </summary>
/// <value></value>
        public bool Rentable{
            get { return _rentable; }
            set { _rentable = value; }
        }
/// <summary>
/// function to calcualte rental fee
/// </summary>
/// <returns></returns>
        public int CalculateRentalFee(){
            return _duration * _rentalfee;
        }
/// <summary>
/// function to retrieve details
/// </summary>
/// <returns></returns>
        public string RetrievedDetails(){
            if (_type == TransportType.Car){
                return "You have a good deal on this";
            }
            else if (_type == TransportType.Motorbike){
                return "The two wheels transport is faster than you expected";
            }
            else{
                return "Drive with care!";
            }
        }
    }
}