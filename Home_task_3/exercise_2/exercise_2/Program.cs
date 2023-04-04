namespace exercise_2
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Input text: ");
            string userInput = Console.ReadLine();
            Console.Write("Input substring: ");
            string substring = Console.ReadLine();
            Console.WriteLine($"Index of second including: {userInput.IndexOfSecondIncluding(substring)}");
            Console.WriteLine($"Count of words that starts with upper letter: {userInput.CountWordsStartsWithUpperLetter()}");
            Console.Write("Input replace string: ");
            string replace = Console.ReadLine();
            string resultReplacing = userInput.ReplaceAllWordsWithDoubleLetters(replace);
            Console.WriteLine($"String after replacing: {resultReplacing}");
        }
    }
}
