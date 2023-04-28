namespace exercise_3
{
    public class Program
    {
        public static void Main()
        {
            WordSearcher wordSearcher = new WordSearcher("Jdoaw    kdau  k jdawu    la Jdoaw     k");
            foreach (string word in wordSearcher.GetUniqueWords())
            {
                Console.WriteLine(word);
            }
        }
    }
}