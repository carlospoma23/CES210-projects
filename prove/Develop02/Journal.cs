using System.IO;
public class Journal
{

    public string _journalName = "journal.txt";
    public List<Entry> _entries = new List<Entry>();

    public void DiplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ReturnEntry());
        }

    }

    public void SavingEntryToFile(Entry newEntry)
    {
        using (StreamWriter outputFile = File.AppendText(_journalName))
        {
            outputFile.WriteLine($"{newEntry.SaveEntry()}");
        }
    }


    public void LoadJournalFromFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_journalName);

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