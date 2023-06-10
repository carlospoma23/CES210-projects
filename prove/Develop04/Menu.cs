using System;

public class Menu{
    private Boolean _exit = false;
    private int _userChoice;
    
    public int GetUserChoice(){
        return _userChoice;
    }
    public void SetUserChoice(int userchoice){
        _userChoice=userchoice;
    }

    public bool GetExit(){
        return _exit;
    }

    public void SetExit(bool exit){
        _exit=exit;
    }

    

    public void DisplayMenu(){
        
        //showing the main Menu
        
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity:");
            Console.WriteLine("2. Start reflecting activity:");
            Console.WriteLine("3. Start listing activity:");
            Console.WriteLine("4. Quit:");
            Console.WriteLine("______________________________");
            Console.Write("Select a choice from the menu: ");
            _userChoice = Int32.Parse(Console.ReadLine());
            //Here is the Swith Case
        }
}