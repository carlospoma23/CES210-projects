
public class Message{

private string _welcomeAssigment;
private string _descriptionAssignment;
private string _startMessage;
private string _endMessage;
private string _timeMessage;


public string GetWelcomeMessage(){
    return _welcomeAssigment;
}
public void SetWelcomeMessage(string welcomeActivity){

_welcomeAssigment=welcomeActivity;
}


public Message(){
_welcomeAssigment="Welcome to Mindfulness Program";
_descriptionAssignment="This program will provides the three activities which help you relaxing";
//_startMessage="Welcome to the ";
}

public Message(string welcomeMessage, string startMessage, string endMessage, string timeMessage){

_welcomeAssigment=welcomeMessage;
_startMessage=startMessage;
_endMessage=endMessage;
_timeMessage=timeMessage;

}


public string ShowWelcomeMessageAssignment(){
    return $"{_welcomeAssigment}\n{_descriptionAssignment}";
}

public string showStartMessage(){
return _startMessage;
}



}