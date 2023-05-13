using System;

public class Entry
{
    public DateTime _dateEntry;
    public String _textEntry;
    public string _promptEntry;

    public void CreateEntry(String prompt)
    {
        _promptEntry = prompt;
        Console.WriteLine($"> : {_promptEntry}");
        _textEntry = Console.ReadLine();
        _dateEntry = DateTime.Today;

        SaveEntry();
    }

    public string ReturnEntry()
    {
        return $"Date: {_dateEntry.ToString("d")} - Prompt :{_promptEntry} \n {_textEntry}   ";
    }

    public String SaveEntry()
    {
        return $"{_dateEntry.ToString("d")} | Prompt : {_promptEntry} | {_textEntry}";
    }





}

