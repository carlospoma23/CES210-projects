using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "People often try to memorize poems or passages of scripture. One of the challenges they encounter is that they want to hide the scripture while they are practicing, but they may not be able to recite the whole scripture from memory just yet.";
        string hiddenText = new string('*', text.Length);

        Console.WriteLine(hiddenText);

        Console.ReadKey();

    }
}