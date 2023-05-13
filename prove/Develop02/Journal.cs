using System.IO;
public class Journal
{

    public string _journalName = "Journal.txt";
    public List<Entry> _entries = new List<Entry>();

    public void DiplayNewEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ReturnEntry());
        }

    }

    public void SavingEntryToFile(Entry newEntry)
    {
        if (!File.Exists(_journalName))
        {
            Console.WriteLine("Please Create the Journal File");
        }
        else
        {

            using (StreamWriter outputFile = File.AppendText(_journalName))
            {
                outputFile.WriteLine($"{newEntry.SaveEntry()}");
            }

        }
    }

    public void CreateJournalFile()
    {
        //Console.WriteLine($"Existe el archivo? {System.IO.File.Exists(_journalName)}");
        if (!File.Exists(_journalName))
        {
            Console.WriteLine("Your file doesn't exist. I will create the file automatically:");
            File.CreateText(_journalName);
            Console.WriteLine($"The file {_journalName} was created successfully");
        }
        else
        {
            Console.WriteLine($"The file  already exists: the name is: {_journalName}");
        }
    }
    public void LoadJournalFromFile()
    {
        if (!File.Exists(_journalName))
        {
            CreateJournalFile();
        }
        string[] lines = System.IO.File.ReadAllLines(_journalName);
        //String text=System.IO.File.ReadAllText(_journalName);

        if (lines.Length == 0)
        {
            Console.WriteLine($"The file {_journalName} is empty, Please enter a Entry");
        }
        else
        {
            foreach (String line in lines)
            {
                String[] parts = line.Split("|");
                String date = parts[0];
                String question = parts[1];
                String answer = parts[2];

                Console.WriteLine($"{date} {question} \n {answer}");

            }

        }
    }

}