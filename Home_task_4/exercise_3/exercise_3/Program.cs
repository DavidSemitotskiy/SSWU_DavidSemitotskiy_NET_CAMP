namespace exercise_3
{
    public class Program
    {
        public static void Main()
        {
            string dataLocation = @"..\..\..\..\data.txt";
            var electricityRep = new ElectricityRepository(dataLocation);
            var result = electricityRep.FindApartmentWithZeroConsumption();
            var apartmentInfo = electricityRep.GetInfoForApartmentByQuarter(3, 3);
            var quarterInfo = electricityRep.GetQuarterInfo(0);
        }
    }
}