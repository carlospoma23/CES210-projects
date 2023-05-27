using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        string file = getFile();
        string[] lines = File.ReadAllLines(file);
        string reference = lines[0];
        string text = String.Join(" ", lines.Skip(1));
        Scripture myScripture = new Scripture(reference, text);

        // Create a new scripture object with the reference and text

        /*
         Scripture myScripture = new Scripture("John 3:16-17", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
    */





        //Displaying the menu
        //showing the main Menu
        Console.WriteLine("******************************");
        Console.WriteLine("WELCOME TO THE SCRIPTURE MEMORIZER");
        Console.WriteLine("******************************");
        Boolean _exit = false;
        int _userChoice;

        while (_exit == false)
        {
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. Display my Scripture Mastery List:");
            Console.WriteLine("2. Add Scripture to the Mastery List:");
            Console.WriteLine("3. Memorize Scripture :");
            Console.WriteLine("4. (Program) End Program :");
            Console.WriteLine("______________________________");
            Console.Write("What do you like to do? ");
            _userChoice = Int32.Parse(Console.ReadLine());

            switch (_userChoice)
            {
                case 1:

                    // journal._entries.Add(myEntry);
                    //journal.SavingEntryToFile(myEntry);
                    _exit = false;
                    break;
                case 2:

                    myScripture.CreateScripture();
                    //journal.DiplayNewEntries();
                    _exit = false;
                    break;
                case 3:

                    Console.Clear();
                    // Display the complete scripture
                    Console.WriteLine(myScripture.ToString());

                    // Prompt the user to press enter or type quit
                    string input;
                    do
                    {
                        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
                        input = Console.ReadLine();

                        if (input != "quit")
                        {
                            // Hide a few random words in the scripture
                            myScripture.HideWords(3);

                            // Clear the console and display the scripture with hidden words
                            Console.Clear();
                            Console.WriteLine(myScripture.ToString());
                        }



                    } while (input != "quit" && !myScripture.IsCompletelyHidden);




                    break;
                case 4:
                    //journal.LoadJournalFromFile();
                    _exit = true;
                    break;
                default:
                    break;

            }





        }

        static string getFile()
        {
            string file = "ScripturesBD.txt";
            return file;
        }

    }



}
