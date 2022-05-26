using System;
using NUnit.Framework;

namespace TransportRegistry{
    [TestFixture()]
    public class TransportTest{
        [Test()]
        public void testcar(){

            Car c = new Car("QAA1234",7,200,true,4);
            Assert.AreEqual(c.RetrievedDetails(),"Plate No: " + c.PlateNo + "\nRental Fee: " + c.RentalFee + "\n** You have a good deal on this **");
        }

        [Test()]
        public void testmotorbike(){

            Motorbike m = new Motorbike("QAA1234",7,200,true,4);
            Assert.AreEqual(m.RetrievedDetails(),"Plate No: " + m.PlateNo + "\nRental Fee: " + m.RentalFee + "\n** The two wheels transport is faster than you expected **");
        }

        [Test()]
        public void testtruck(){

            Truck t = new Truck("QAA1234",7,200,true, 2700,8);
            Assert.AreEqual(t.RetrievedDetails(), "Plate No: " + t.PlateNo + "\nWeight: " + t.Weight + "\nRental Fee: " +  t.RentalFee + "\n** Drive with care! **");
            Truck t2 = new Truck("QAA1234",7,200,false, 2700,8);
            Assert.AreEqual(t2.RetrievedDetails(), "** Truck rental service is not available at the moment **");
        }

        [Test()]
        public void calcrentalfee(){
            
            Transport c = new Car("QAA1234",7,200,true,4);
            Assert.AreEqual(c.CalculateRentalFee(),1400);
        }
    }
}