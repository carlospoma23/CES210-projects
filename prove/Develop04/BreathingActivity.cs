public class BreathingActivity: Activity{

    private int _count;
    private string _startMessage;
    public string _endMessage;
    public string _breathingMessage;
    public string _breathInMessage;
    public string _breathOutMessage;


    //setting getters and setters
    public int  GetCount(){
    return _count;
    }

    public void SetCount(int count){
        _count=count;
    }

    public string  GetStartMessage(){
    return _startMessage;
    }
    public void  SetStartMessage(string startMessage){
        _startMessage=startMessage;
    }

    //Setting constructors
    //first constructor 
    public BreathingActivity(): base(){

    }

    public BreathingActivity(string name, string description,int duration):base(name,description,duration){
    _name="Breathing Activity.";
    _startMessage="Get Ready";

    }


    public BreathingActivity(string name, string description,int duration, string startMessage):base(name,description,duration){

    _startMessage="";

    }

    //Setting methods

    public string DisplayBreathinMessage(bool status){
        if (status==true){
            _breathingMessage=_breathInMessage;
        }else{
            _breathingMessage=_breathOutMessage;
        }
        return _breathingMessage;
    }



}

