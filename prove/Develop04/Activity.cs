public class Activity {

    private string _name;
    private string _description;
    private int _duration;
    private string _startMessage;
    private string _endMessage;


    //setting Getters and Setters
    public string GetName(){
        return _name;
    }
    public void SetName(string name){
        _name=name;
    }
    public string GetDescription(){
        return _description;
    }
    public void SetDescription(string description){
      _description=description;
    }

    public int GetDuration(){
        return _duration;
    }
    public void GetDuration(int duration){
      _duration=duration;
    }

     
    public string  GetStartMessage(){
        return _startMessage;
    }
    public void  SetStartMessage(string startMessage){
        _startMessage=startMessage;
    }

    public string  GetEndMessage(){
        return _endMessage;
    }
    public void  SetEndMessage(string endMessage){
        _endMessage=endMessage;
    }


    //Setting Constructors
    public Activity(){
    }

    public Activity(string name , string description, int duration){
        _name=name;
        _description=description;
        _duration=duration;
    }

    public string  DisplayStartingMessage(){

        return $"{_name}\n{_description}";

    }
    public string DisplayEndingMessage(){

        return "";
    }



    public bool PausinWhileShowingSpinner(){


        return false;

    }

    public bool PausingWhileShowingCountdownTimer(){

        return  false;
    
    }


}