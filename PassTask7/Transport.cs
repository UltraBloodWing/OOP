using System;

namespace TransportRegistry{
    public class Transport{
        private string _plateNo;
        private int _duration;
        private int _rentalfee;
        private bool _rentable;
        private TransportType _type;

        public Transport( string plateNo, int duration, int rentalfee, bool rentable, TransportType type){
            _plateNo = plateNo;
            _duration = duration;
            _rentalfee = rentalfee;
            _rentable = rentable;
            _type = type;
        }
        public string PlateNo{
            get { return _plateNo; }
            set { _plateNo = value; }
        }
        public int Duration{
            get { return _duration; }
            set { _duration = value; }
        }
        public int RentalFee{
            get { return _rentalfee; }
            set { _rentalfee = value; }
        }
        public bool Rentable{
            get { return _rentable; }
            set { _rentable = value; }
        }
        public int CalculateRentalFee(){
            return _duration * _rentalfee;
        }
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