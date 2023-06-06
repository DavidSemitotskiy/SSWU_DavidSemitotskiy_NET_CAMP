namespace exercise_1
{
    public class Program
    {
        public static void Main()
        {
            ICardValidator cardValidator = new LuhnCardValidator();
            Console.WriteLine(cardValidator.ValidateCard("4244 7310 0316 8315"));
            Console.WriteLine(cardValidator.ValidateCard("5186980144190681"));
            Console.WriteLine(cardValidator.ValidateCard("374823303505138"));
            Console.WriteLine(cardValidator.ValidateCard("374823304505138"));
            Console.WriteLine(cardValidator.ValidateCard("37482330a505138"));
        }
    }
}