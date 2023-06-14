public class BreathingActivity : Activity
{

    private int _count;

    public string _breathingMessage;
    public string _breathInMessage;
    public string _breathOutMessage;


    //setting getters and setters
    public int GetCount()
    {
        return _count;
    }

    public void SetCount(int count)
    {
        _count = count;
    }

    public void SetBreathingMessage(string message)
    {
        _breathingMessage = message;
    }

    //Setting constructors
    //first constructor 
    public BreathingActivity() : base()
    {

    }

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        //_name="Breathing Activity.";
        //_startMessage="Get Ready";

    }


    public BreathingActivity(string name, string description, int duration, string startMessage) : base(name, description, duration)
    {


    }

    //Setting methods

    public string DisplayBreathinMessage()
    {
        return _breathingMessage;
    }



}
