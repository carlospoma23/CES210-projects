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

        Console.WriteLine("WELCOME TO THE JOURNAL PROGRAM");
        Console.WriteLine("______________________________");
        Boolean _exit = false;
        int _userChoice;

        while (_exit == false)
        {
            Console.WriteLine("1. Write :");
            Console.WriteLine("2. Display :");
            Console.WriteLine("3. Load :");
            Console.WriteLine("4. Save :");
            Console.WriteLine("5. Quit :");

            Console.Write("What do you like to do? ");
            _userChoice = Int32.Parse(Console.ReadLine());

            switch (_userChoice)
            {
                case 1:
                    promtRandom.DisplayRandomQuestion();
                    Console.Write("> :");
                    Entry myEntry = new Entry();
                    myEntry.CreateEntry();
                    journal._entries.Add(myEntry);
                    journal.SavingEntryToFile(myEntry);

                    _exit = false;
                    break;
                case 2:

                    journal.DiplayJournal();
                    _exit = false;
                    break;

                case 3:
                    Console.WriteLine($"Option : {_userChoice}");
                    break;
                case 4:
                    Console.WriteLine($"Option : {_userChoice}");
                    break;
                case 5:
                    _exit = true;
                    break;

            }






        }



    }
}