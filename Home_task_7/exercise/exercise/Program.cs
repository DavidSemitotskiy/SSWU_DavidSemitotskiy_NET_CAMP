namespace exercise
{
    public class Program
    {
        public static void Main()
        {
            Crossroad fourSideCrossroad = new FourSideCrossroad(TimeSpan.FromSeconds(2));
            Console.ReadKey();
        }
    }
}