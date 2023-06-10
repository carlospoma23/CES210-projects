public class WritingAssigment : Assignment{

private String _title;


public WritingAssigment(): base(){

}

public string GetTitle(){
    return _title;

}
public void SetTitle(string title){
    _title=title;
}


public WritingAssigment(string studentName, string topic, string title): base(studentName,topic){

_title=title;

}


public string GetWritingInformation(){

    return $"{_title} by {_studentName}";
}


}