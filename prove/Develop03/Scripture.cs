using System;

public class Scripture
{

    private List<Word> _parragraph = new List<Word>();

    private Reference _reference;


    public Scripture(string text, Reference reference)
    {

        String[] words = text.Split(' ');

        _parragraph = new List<Word>();

        foreach (string word in words)
        {

            _parragraph.Add(new Word(word));
        }


        _reference = reference;

    }




    public void HideWords()
    {



    }

    public string GetRenderedText()
    {

        return null;
    }


    public string IsCompletelyHidden()
    {

        return null;

    }



}