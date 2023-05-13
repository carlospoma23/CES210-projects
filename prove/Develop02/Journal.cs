using System.IO;
public class Journal
{

    public string _journalName = "";
    public List<Entry> _entries = new List<Entry>();

    Entry entry = new Entry();
    public void DiplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ReturnEntry());
        }

    }




    public void SavingEntryToFile(Entry myentry)
    {
        String filename = "Journal.txt";
        using (StreamWriter outputFile = File.AppendText(filename))
        {
            outputFile.WriteLine($"{myentry.SaveEntry()}");
        }
    }


    public void LoadFromFile()
    {

        Console.Write("abd");
    }

}