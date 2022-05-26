using System;

namespace PassTask2
{
    class Program
    {
        public static void PrintCounters(Counter[] myCounters){       //1  no new counter here, why?
            foreach (Counter c in myCounters){                   //2 also counter here
                Console.WriteLine(c.Name + " is " + c.Value);
            }
        }
        static void Main(string[] args){           // what is static?
            Counter[] myCounters = new Counter[3];
            int i;

            myCounters[0] = new Counter("Counter 1");   //1 new counter here
            myCounters[1] = new Counter("Counter 2");      //2 no counter here
            myCounters[2] = myCounters[0];
           
            for (i=0; i<5; i++){
                myCounters[0].Increment();
            }

            for (i=0; i<10; i++){
                 myCounters[1].Increment();
            }

            PrintCounters(myCounters);

            myCounters[2].Reset();

            PrintCounters(myCounters); 

        }
    }
}