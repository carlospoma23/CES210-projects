public class PromtGenerator
{
    public List<String> _promtQuestionRandom = new List<string>();
    public string ReturnRamdomQuestion()
    {
        var randomQuestion = new Random();
        int count = _promtQuestionRandom.Count();
        int indexVal = randomQuestion.Next(count);
        string prompt = _promtQuestionRandom[indexVal];
        return prompt;
    }

}