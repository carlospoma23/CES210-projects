using System;

public class Menu{

    public void CallMenu(){
        
        //showing the main Menu
        Boolean _exit = false;
        int _userChoice;

        while (_exit == false)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity:");
            Console.WriteLine("2. Start reflecting activity:");
            Console.WriteLine("3. Start listing activity:");
            Console.WriteLine("4. Quit:");
            Console.WriteLine("______________________________");
            Console.Write("Select a choice from the menu: ");
            _userChoice = Int32.Parse(Console.ReadLine());

            switch (_userChoice)
            {
                case 1:
                    // journal._entries.Add(myEntry);
                    //journal.SavingEntryToFile(myEntry);
                    _exit = false;
                    break;
                case 2:
                    //journal.DiplayNewEntries();
                    _exit = false;
                    break;
                case 3:
                    // Display the complete scripture
                    // Prompt the user to press enter or type quit
                    string input;
                    do
                    {
                        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
                        input = Console.ReadLine();

                        if (input != "quit")
                        {
                            // Hide a few random words in the scripture
                            // Clear the console and display the scripture with hidden words
                            Console.Clear();
                        }
                    } while (input != "quit");
                    break;
                case 4:
                    //journal.LoadJournalFromFile();
                    _exit = true;
                    break;
                default:
                    break;

            }
        }
        }
}