using System;

class Program
{

    static void Main(string[] args)
    {

        //Adding quesitons for the PromtGenerator
        PromtGenerator promtRandom = new PromtGenerator();
        promtRandom._promtQuestionRandom.Add("Who was the most interesting person I interacted with today?");
        promtRandom._promtQuestionRandom.Add("What was the best part of my day?");
        promtRandom._promtQuestionRandom.Add("How did I see the hand of the Lord in my life today?");
        promtRandom._promtQuestionRandom.Add("What was the strongest emotion I felt today?");
        promtRandom._promtQuestionRandom.Add("If I had one thing I could do over today, what would it be?");



        Journal journal = new Journal();
        //showing the main Menu
        Console.WriteLine("******************************");
        Console.WriteLine("WELCOME TO THE JOURNAL PROGRAM");
        Console.WriteLine("******************************");
        Boolean _exit = false;
        int _userChoice;

        while (_exit == false)
        {
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. (Entry) Write new Entry :");
            Console.WriteLine("2. (Entry) Display new(s) Entry(ies):");
            Console.WriteLine("3. (Journal) Load the Journal:");
            Console.WriteLine("4. (Journal) Change Journal's name :");
            Console.WriteLine("5. (Program) End Program :");
            Console.WriteLine("______________________________");
            Console.Write("What do you like to do? ");
            _userChoice = Int32.Parse(Console.ReadLine());

            switch (_userChoice)
            {
                case 1:
                    string prompt = promtRandom.ReturnRamdomQuestion();
                    Entry myEntry = new Entry();
                    myEntry.CreateEntry(prompt);
                    journal._entries.Add(myEntry);
                    journal.SavingEntryToFile(myEntry);
                    _exit = false;
                    break;
                case 2:
                    journal.DiplayNewEntries();
                    _exit = false;
                    break;
                case 3:
                    journal.LoadJournalFromFile();
                    break;
                case 4:
                    journal.ChangeJournalName();
                    break;
                case 5:
                    _exit = true;
                    break;

            }






        }



    }
}