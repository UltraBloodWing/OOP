using System;

namespace TransportRegistry
{
    class Program{
        static void Print(Transport[] transports){

            foreach (Transport t in transports){

                Console.WriteLine("The total rental fee is " + t.CalculateRentalFee());
                Console.WriteLine(t.RetrievedDetails() + "\n");
            }
        }

        static void Main(string[] args){

            Console.WriteLine("101214608 \n");

            Transport[] transports = new Transport[3];

            transports[0] = new Car("QAA1234",7,200,true, 7);
            transports[1] = new Motorbike("QAR7890",4,50,true, 4);
            transports[2] = new Truck("PAA4568",14,350,true, 2700, 8);

            Print(transports);
        }
    }
}
