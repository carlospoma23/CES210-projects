using System;

public class Entry
{
    public DateTime _dateEntry;
    public String _entryText;

    public void CreateEntry()
    {
        _entryText = Console.ReadLine();
        _dateEntry = DateTime.Today;

    }

    public string ReturnEntry()
    {
        return $"Date: {_dateEntry.ToString("d")} - Prompt {_entryText}";
    }

    public String SaveEntry()
    {
        return $"{_dateEntry.ToString("d")} | Prompt {_entryText}";
    }





}

