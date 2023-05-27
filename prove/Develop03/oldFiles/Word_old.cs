using System;

public class Word_old
{

    private string _text;
    public bool _ishiddenWord;

    public Word_old(string text, bool isHide)
    {
        _text = text;
        _ishiddenWord = isHide;
    }

    public Word_old(string text)
    {
        _text = text;
        _ishiddenWord = true;
    }

    public void HideWord()
    {
        _ishiddenWord = true;
    }

    public void Show()
    {
        _ishiddenWord = false;
    }

    public string IsHiddenWord()
    {
        return _ishiddenWord ? "_____" : _text;

    }

}