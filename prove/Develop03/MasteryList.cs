public class myScriptures
{
    private string _dbScriptures = "ScripturesBD.txt";
    private List<Scripture> _scriptures = new List<Scripture>();




    public void SavingScriptureToFile(Scripture newEntry)
    {
        if (!File.Exists(_dbScriptures))
        {
            Console.WriteLine("Please Create the Journal File");
        }
        else
        {

            using (StreamWriter outputFile = File.AppendText(_dbScriptures))
            {
                outputFile.WriteLine($"{newEntry.ToString()}");
            }

        }
    }
    public void CreateMasteryList()
    {
        if (!File.Exists(_dbScriptures))
        {
            Console.WriteLine("Your file doesn't exist. I will create the file automatically:");
            File.CreateText(_dbScriptures);
            Console.WriteLine($"The file {_dbScriptures} was created successfully");
        }
        else
        {
            Console.WriteLine($"The file  already exists: the name is: {_dbScriptures}");
        }
    }

    public void DisplayMasteryFromFile()
    {
        if (!File.Exists(_dbScriptures))
        {
            CreateMasteryList();
        }
        string[] lines = System.IO.File.ReadAllLines(_dbScriptures);
        //String text=System.IO.File.ReadAllText(_journalName);

        if (lines.Length == 0)
        {
            Console.WriteLine($"The file {_dbScriptures} is empty, Please enter a Entry");
        }
        else
        {
            foreach (String line in lines)
            {
                String[] parts = line.Split("|");
                String reference = parts[0];
                String text = parts[1];

                Console.WriteLine($"{reference} \n {text}");

            }

        }
    }



}