using System;
using NUnit.Framework;

namespace TransportRegistry{
    [TestFixture()]
    public class RentalTest{
        [Test()]
        public void AddTesting(){
            Rental myRental = new Rental();
            int count = myRental.TransportCount;

            Assert.AreEqual(0,count);

            myRental.AddTransport(new Transport("QAA1234",7,200,true, TransportType.Car));
            myRental.AddTransport(new Transport("QAR7890",4,50,true, TransportType.Motorbike));

            count = myRental.TransportCount;

            Assert.AreEqual(2,count);
        }
        [Test()]
        public void RemoveTesting(){

            Rental myRental = new Rental();

            int count = myRental.TransportCount;

            Assert.AreEqual(0,count);

            Transport[] TestTransports = {
                new Transport("QAA1234",7,200,true, TransportType.Car),
                new Transport("QAA1234",7,200,true, TransportType.Car),
                new Transport("QAA1234",7,200,true, TransportType.Car)
            };

            foreach(Transport t in TestTransports){
                myRental.AddTransport(t);
            }

            count = myRental.TransportCount;

            Assert.AreEqual(3,count);
            
            myRental.RemoveTransport(TestTransports[1]);

            count = myRental.TransportCount;

            Assert.AreEqual(2,count);

        }
         [Test()]
        public void TestIndexer(){
            Rental myRental  = new Rental();
            Transport[] TestTransports = {
                new Transport("QAA1234",7,200,true, TransportType.Car),
                new Transport("QAA1234",7,200,true, TransportType.Car),
                new Transport("QAA1234",7,200,true, TransportType.Car)
            };

           foreach(Transport t in TestTransports){
                myRental.AddTransport(t);
            }
            
            Assert.AreEqual(myRental[0],TestTransports[0]);
        }
    }
}