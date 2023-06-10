
public class MathAssignment : Assignment{


    private string _textbookSection;
    private string _problems;

    public MathAssignment() :base(){

    }

    public MathAssignment(string studenName,string topic,string textbookSection, string problems): base(studenName,topic){

        _textbookSection=textbookSection;
        _problems=problems;

    }

    public string GetTexbookSection(){
        return _textbookSection;
    }

    public void SetTextbookSection(string textbookSection){

        _textbookSection=textbookSection;
    }

    public string GetProblems(){
        return _problems;
    }

    public void SetTextProblems(string problems){
        _problems=problems;
    }


    public string GetHomeworkList(){

        return $"Section {_textbookSection} -  Problems {_problems}";

    }

}