namespace exercise_1
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<string> textUkrainian = new List<string>
            {
                "Дано текст, який потрібно розмістити в колекцію стрічок",
                "(можна для збереження використовувати і масив).",
                "Текст містить (якийсь текст) речення, які не",
                "обов’язково розташовані в одній стрічці.",
                "Речення можуть закінчуватися",
                "крапкою, знаком оклику та знаком запитання.",
                "Вважати, що цих знаків",
                "не може бути в середині речень.",
                "У реченнях може бути текст в круглих дужках.",
                "Потрібно знайти та видрукувати всі речення, які містять інформацію в дужках.",
                "Вкладених круглих дужок немає.",
                "Розв’язати задачу, не використовуючи злиття(конкатенацію) стрічок",
                "та продемонструвати виконання для текстів українською",
                "та англійською мовами."
            };
            TextSearcher textSearcher1 = new TextSearcher(textUkrainian);
            var result1 = textSearcher1.FindRowsWithBrackets();
            PrintText(result1);

            List<string> textEnglish = new List<string>()
            {
                "The cat lazily(some text) stretched",
                "out on the windowsill(some text),",
                "basking in the warm afternoon sun.",
                "After a long day at work,",
                "Sarah enjoyed relaxing in her favorite armchair with",
                "a good book and a cup of tea."
            };
            TextSearcher textSearcher2 = new TextSearcher(textEnglish);
            var result2 = textSearcher2.FindRowsWithBrackets();
            PrintText(result2);
        }

        public static void PrintText(List<string> text)
        {
            foreach (string s in text)
            {
                Console.Write($"{s} ");
            }

            Console.WriteLine();
        }
    }
}