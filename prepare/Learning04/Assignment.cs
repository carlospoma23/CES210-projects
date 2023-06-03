using System;
public class Assignment{

    protected string _studentName;
    protected string _topic;


    public string GetStudentName(){
        return _studentName;
    }

    public void SetStudentName(string studenName){
        
        _studentName=studenName;
    }

    public string GetTopic(){
        return _topic;
    }

    public void SetTopic(string topic){
        _topic=topic;

    }

    public Assignment(){
        _studentName="Samuel Bennet";
        _topic="Multiplication";

    }

//Constructor Create by me, Carlos Poma
    public Assignment(string studenName, string topic){

        _studentName=studenName;
        _topic=topic;
    }

  

    public string GetSummary()
    {
        return $"{_studentName} and  {_topic}";
    }

}