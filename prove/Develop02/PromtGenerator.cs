public class PromtGenerator
{
    public List<String> _promtQuestionRandom = new List<string>();
    public void DisplayRandomQuestion()
    {
        var randomQuestion = new Random();
        int count = _promtQuestionRandom.Count();
        int indexVal = randomQuestion.Next(count);
        Console.WriteLine(_promtQuestionRandom[indexVal]);

    }

}