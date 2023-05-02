namespace exercise_3
{
    public class WordSearcher
    {
        private string _text;

        public WordSearcher(string text) 
        {
            _text = text;
        }

        public IEnumerable<string> GetUniqueWords()
        {
            string text = _text;
            text = text?.Trim();
            // Надлишково закручено. Можна за допомогою множин...
            (string? word, bool isSuccess) resultGettingWord;
            while ((resultGettingWord = GetWord(text)).isSuccess)
            {
                if (text.IndexOf(resultGettingWord.word, resultGettingWord.word.Length) == -1)
                {
                    yield return resultGettingWord.word;
                }

                text = text.Replace(resultGettingWord.word, "").TrimStart();
            }
        }

        private (string?, bool) GetWord(string text)
        {
            if (text == null || string.IsNullOrWhiteSpace(text))
            {
                return (null, false);
            }

            int indexOfEndWord = text.IndexOf(' ');
            return indexOfEndWord == -1 ? (text, true) : (text[..indexOfEndWord], true);
        }
    }
}
