namespace exercise_1
{
    public class TextSearcher
    {
        private List<string> _textList;

        private char[] _rowSeparators = { '.', '!', '?' };

        public TextSearcher(List<string> textList)
        {
            _textList = textList;
        }

        public List<string> FindRowsWithBrackets()
        {
            int indexStartRow = 0;
            int leftBracket = 0;
            int rightBracket = 0;
            List<string> rowsWithBrackets = new List<string>();
            for (int i = 0; i < _textList.Count && indexStartRow < _textList.Count; i++)
            {// У Вас може бути кілька речень в одній стрічці. У такому разі Ви матимете тільки 1.
                if (((leftBracket = _textList[i].IndexOf('(')) != -1 && (rightBracket = _textList[i].IndexOf(')')) != -1) && rightBracket > leftBracket)
                {
                    i = CreateRow(rowsWithBrackets, indexStartRow);
                    indexStartRow = i + 1;
                }
                else if(ContainsRowSeparator(_textList[i]))
                {
                    indexStartRow = i + 1;
                }
            }

            return rowsWithBrackets;
        }

        private int CreateRow(List<string> rowsWithBrackets, int indexStart)
        {
            bool endFound = false;
            int indexEnd = 0;
            for (int i = indexStart; i < _textList.Count && !endFound; i++)
            {
                if (ContainsRowSeparator(_textList[i]))
                {
                    endFound = true;
                    indexEnd = i;
                }

                rowsWithBrackets.Add(_textList[i]);
            }

            return indexEnd;
        } 

        private bool ContainsRowSeparator(string str)
        {// тут правильно, але краще було б працювати з множиною.
            for (int i = 0; i < _rowSeparators.Length; i++)
            {
                if (str.IndexOf(_rowSeparators[i]) != -1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
