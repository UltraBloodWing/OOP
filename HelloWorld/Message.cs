using System;

namespace HelloWorld
{
   public class Message
   {
       private string text; //field/var

       public Message(string txt) //method/function
       {
            text = txt;
       }

       public void Print()
       {
           Console.WriteLine(text);
       }
   }
}
