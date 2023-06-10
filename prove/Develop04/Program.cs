using System;

class Program
{
    static void Main(string[] args)
    {
    
    Console.WriteLine("Hello Develop04 World!");
    Message myMessage= new Message();

    //myMessage.SetWelcomeMessage("Welcome to the program 1 en llamar");

    Console.WriteLine(myMessage.ShowWelcomeMessageAssignment());
    Console.WriteLine(myMessage.showStartMessage());

    Activity myActivity=new Activity();

    }

    
}