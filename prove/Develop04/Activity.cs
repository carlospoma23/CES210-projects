public class Activity {

    private string _name;
    private string _description;
    private int _duration;


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
    public void GetDescription(string description){
      _description=description;
    }

    public int GetDuration(){
        return _duration;
    }
    public void GetDuration(int duration){
      _duration=duration;
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

        return "";

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