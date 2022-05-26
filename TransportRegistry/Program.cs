using System;

namespace TransportRegistry
{
    class Program
    {
        public static void Print(Transport[] transports){
            foreach (Transport t in transports){
                Console.WriteLine("The total rental fee is " + t.CalculateRentalFee());
                Console.WriteLine(t.RetrievedDetails() + "\n");
            }
        }
        static void Main(string[] args)
        {
            Transport[] transports = new Transport[3];

            transports[0] = new Transport("QAA1234",7,200,true,TransportType.Car);
            transports[1] = new Transport("QAR7890",4,50,true,TransportType.Motorbike);
            transports[2] = new Transport("PAA4568",14,350,false,TransportType.Truck);

            Print(transports);
        }
    }
}