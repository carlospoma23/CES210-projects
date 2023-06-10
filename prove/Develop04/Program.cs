using System;

class Program
{
    static void Main(string[] args)
    {
    Console.Clear();
    Message myMessage= new Message();

    //myMessage.SetWelcomeMessage("Welcome to the program 1 en llamar");

    Console.WriteLine(myMessage.ShowWelcomeMessageAssignment());
    Console.WriteLine(myMessage.showStartMessage());
    Console.WriteLine("****************************************");

    //Activity myActivity=new Activity();

    Menu myMenu = new Menu();

    myMenu.CallMenu();


    }


}