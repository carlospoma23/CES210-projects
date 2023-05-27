using System;


public class Reference_old
{
    private string _book;
    private int _chapter;

    private int _initverse;
    private int _Finalverse;


    public Reference_old(String book, int chapter, int initVerse)
    {
        _book = book;
        _chapter = chapter;
        _initverse = initVerse;
    }
    public Reference_old(String book, int chapter, int initVerse, int finalverse)
    {
        _book = book;
        _chapter = chapter;
        _initverse = initVerse;
        _Finalverse = finalverse;
    }




}