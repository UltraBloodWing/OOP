using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Message message = new Message("Hello World!");
            message.Print();

            Message myMessage = new Message("\nHello World...");

            Message[] messages = new Message[4];
            
            string name;

            myMessage.Print();
            
            messages[0] = new Message("Welcome back oh great creator!");
            messages[1] = new Message("What a lovely name");
            messages[2] = new Message("Great name");
            messages[3] = new Message("That is a silly name");

            Console.Write("Enter name: ");
            name = Console.ReadLine();

            if(name.ToLower() == "andrew"){
                messages[0].Print();
            }
            else if(name.ToLower() == "fred"){
                messages[1].Print();
            }
            else if(name.ToLower() == "wilma"){
                messages[2].Print();
            }
            else{
                messages[3].Print();
            }
        }
    }
}