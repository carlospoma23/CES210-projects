using System;
public class Activity
{

    private string _name;
    private string _description;
    private int _duration;
    private string _startMessage;
    private string _endMessage;


    //setting Getters and Setters
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }


    public string GetStartMessage()
    {
        return _startMessage;
    }
    public void SetStartMessage(string startMessage)
    {
        _startMessage = startMessage;
    }

    public string GetEndMessage()
    {
        return _endMessage;
    }
    public void SetEndMessage(string endMessage)
    {
        _endMessage = endMessage;
    }


    //Setting Constructors

    public Activity()
    {
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string DisplayStartingMessage()
    {
        Console.Clear();
        return $"\n{_name}\n\n{_description}";

    }
    public string DisplayEndingMessage()
    {

        return "";
    }



    public void PausinWhileShowingSpinner()
    {

        List<string> animationsStrings = new List<string>();
        animationsStrings.Add("|");
        animationsStrings.Add("/");
        animationsStrings.Add("-");
        animationsStrings.Add("\\");
        animationsStrings.Add("|");
        animationsStrings.Add("/");
        animationsStrings.Add("-");
        animationsStrings.Add("\\");

        foreach (string s in animationsStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void PausingWhileShowingCountdownTimer()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void PausingWhileShowingPeriods()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);

        }

    }


}