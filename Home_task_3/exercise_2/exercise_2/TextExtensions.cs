namespace exercise_2
{
    public static class TextExtensions
    {
        public static int? IndexOfSecondIncluding(this string str, string substring)
        {
            int firstOffset = str.IndexOf(substring);
            if (firstOffset == -1)
            {
                return null;
            }

            int result = str.IndexOf(substring, firstOffset + substring.Length);
            return result == -1 ? null : result;
        }

        public static int CountWordsStartsWithUpperLetter(this string str)
        {
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int countWords = 0;
            foreach (string word in words)
            {
                if (char.IsUpper(word[0]))
                {
                    countWords++;
                }
            }

            return countWords;
        }

        public static string ReplaceAllWordsWithDoubleLetters(this string str, string replace)
        {
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            bool containsDoubleLetters = false;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length - 1; j++)
                {
                    if (words[i][j] == words[i][j + 1])
                    {
                        containsDoubleLetters = true;
                        break;
                    }
                }

                if (containsDoubleLetters)
                {
                    words[i] = replace;
                    containsDoubleLetters = false;
                }
            }

            return string.Join(' ', words);
        }
    }
}
