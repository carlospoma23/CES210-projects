using System;

public class Scripture_old
{
    /*
        private List<Word> _parragraph = new List<Word>();

        private Reference _reference;


        public Scripture_old(Reference reference, string text)
        {

            String[] _words = text.Split(' ');

            _parragraph = new List<Word>();

            foreach (string word in _words)
            {

                _parragraph.Add(new Word(word));
            }

            _reference = reference;

            ;
        }
        public void HideWords()
        {
            var random = new Random();
            int wordCount = _parragraph.Count(w => !w._ishiddenWord);
            if (wordCount == 0) return;
            var wordIndex = random.Next(0, wordCount);
            var wordToHide = _parragraph.Where(w => !w._ishiddenWord).ElementAt(wordIndex);
            wordToHide.HideWord();
        }

        public string GetRenderedText()
        {
            return $"{_reference}\n\n{string.Join(" ", _parragraph)}";
        }


        public bool IsCompletelyHidden()
        {
            return true;

        }

    */

}