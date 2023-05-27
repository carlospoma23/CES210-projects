public class Word
{
    public string _word;
    public bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public Word(string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }



}