using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Message myMessage = new Message();

        //myMessage.SetWelcomeMessage("Welcome to the program 1 en llamar");

        Console.WriteLine(myMessage.ShowWelcomeMessageAssignment());
        Console.WriteLine(myMessage.showStartMessage());
        Console.WriteLine("****************************************");

        Menu myMenu = new Menu();

        while (myMenu.GetExit() == false)
        {
            myMenu.DisplayMenu();
            switch (myMenu.GetUserChoice())
            {
                case 1:
                    BreathingActivity B1 = new BreathingActivity();
                    int input;
                    B1.SetName("Breathing Activity.");
                    B1.SetDescription("This Activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    Console.Write("Please enter the time : ");
                    input = Int32.Parse(Console.ReadLine());
                    B1.SetDuration(input);
                    Console.WriteLine(B1.DisplayStartingMessage());
                    break;

                case 2:
                    Console.WriteLine("Case 2");
                    //myMenu.SetExit(false);
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    //myMenu.SetExit(false);
                    break;
                case 4:
                    //Console.WriteLine("Case 4");
                    myMenu.SetExit(true);
                    break;
                default:
                    Console.WriteLine("Please Select just 1 - 4 options");
                    break;
            }
        }


    }
}