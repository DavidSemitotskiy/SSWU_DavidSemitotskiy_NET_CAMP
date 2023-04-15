namespace exercise_3
{
    public class Program
    {
        public static void Main()
        {
            string dataLocation = @"..\..\..\..\data.txt";
            var electricityRep = new ElectricityRepository(dataLocation);
        }
    }
}