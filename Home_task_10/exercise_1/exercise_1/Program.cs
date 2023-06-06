namespace exercise_1
{
    public class Program
    {
        public static void Main()
        {
            ICardValidator cardValidator = new LuhnCardValidator();
        }
    }
}