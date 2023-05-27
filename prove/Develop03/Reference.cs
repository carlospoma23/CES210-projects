public class Reference
{
    private string _book;
    private int _chapter;
    private int? _initVerse;
    private int? _finalVerse;

    public Reference(string book, int chapter, int initVerse)
    {
        _book = book;
        _chapter = chapter;
        _initVerse = initVerse;
    }

    public Reference(string book, int chapter, int initVerse, int finalVerse)
    {
        _book = book;
        _chapter = chapter;
        _initVerse = initVerse;
        _finalVerse = finalVerse;
    }

    public Reference(string reference)
    {
        // Parse the reference string into book, chapter, and verse
        string[] parts = reference.Split(' ');
        _book = parts[0];
        _chapter = int.Parse(parts[1].Split(':')[0]);
        string[] verseParts = parts[1].Split(':')[1].Split('-');
        _initVerse = int.Parse(verseParts[0]);
        _finalVerse = verseParts.Length > 1 ? int.Parse(verseParts[1]) : (int?)null;
    }


    public override string ToString()
    {
        string verse = _finalVerse.HasValue ? $"{_initVerse}-{_finalVerse}" : $"{_initVerse}";
        return $"{_book} {_chapter}:{verse}";
    }




}






