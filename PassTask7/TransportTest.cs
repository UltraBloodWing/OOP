using System;
using NUnit.Framework;

namespace TransportRegistry{
    [TestFixture()]
    public class TransportTest{
        [Test()]
        public void testcar(){

            Transport t = new Transport("QAA1234",7,200,true, TransportType.Car);
            Assert.AreEqual(t.RetrievedDetails(),"You have a good deal on this");
        }

        [Test()]
        public void testmotorbike(){

            Transport t = new Transport("QAA1234",7,200,true, TransportType.Motorbike);
            Assert.AreEqual(t.RetrievedDetails(),"The two wheels transport is faster than you expected");
        }

        [Test()]
        public void testtruck(){

            Transport t = new Transport("QAA1234",7,200,true, TransportType.Truck);
            Assert.AreEqual(t.RetrievedDetails(),"Drive with care!");
        }

        [Test()]
        public void calcrentalfee(){
            
            Transport t = new Transport("QAA1234",7,200,true, TransportType.Car);
            Assert.AreEqual(t.CalculateRentalFee(),1400);
        }
    }
}