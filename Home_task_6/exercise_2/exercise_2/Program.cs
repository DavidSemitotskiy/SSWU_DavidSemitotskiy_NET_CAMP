namespace exercise_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int[] first = Enumerable.Range(0, 10).Select(_ => random.Next(600)).ToArray();
            int[] second = Enumerable.Range(0, 3).Select(_ => random.Next(600)).ToArray();
            int[] third = Enumerable.Range(0, 4).Select(_ => random.Next(600)).ToArray();
            foreach (int i in Sorter.MergeAndSortCollectionsLinq(first, second, third))
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            foreach (int i in Sorter.MergeAndSortCollections(first, second, third))
            {
                Console.Write($"{i} ");
            }
        }
    }
}