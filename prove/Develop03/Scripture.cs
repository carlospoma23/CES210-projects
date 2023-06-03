public class Scripture
{
    public List<Word> _words = new List<Word>();
    public Reference _reference;

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool IsCompletelyHidden
    {
        get
        {
            return _words.All(word => word._isHidden);
        }
    }
    public void HideWords(int count)
    {
        Random random = new Random();
        List<Word> hiddenWords = new List<Word>();
        for (int i = 0; i < count; i++)
        {
            Word word = _words[random.Next(_words.Count)];
            while (word._isHidden)
            {
                word = _words[random.Next(_words.Count)];
            }
            // Hide the word
            word._isHidden = true;
            hiddenWords.Add(word);
            if (IsCompletelyHidden)
            {
                break;
            }


        }
    }
    public override string ToString()
    {
        string text = String.Join(" ", _words.Select(word => word._isHidden ? "_____" : word._word));
        return $"{_reference.ToString()}: {text}";
    }

    public void CreateScripture()
    {
        Console.Write("Enter the reference (Book 2:2-5)");
        Reference RefEnterByUSer = new Reference(Console.ReadLine());
        _reference = RefEnterByUSer;

        Console.WriteLine("Enter the Scripture's text");
        string enterUserText = Console.ReadLine();



    }

}

