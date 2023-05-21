using System;

public class Word
{

    private string _word;
    private bool _ishiddenWord;


    public Word(string word, bool isHide)
    {

        _word = word;
        _ishiddenWord = isHide;

    }

    public Word(string word)
    {
        _word = word;
        _ishiddenWord = true;

    }

    public string HideWord()
    {

        return null;
    }

    public string Show()
    {

        return null;
    }

    public void IsHiddenWord()
    {

    }






}