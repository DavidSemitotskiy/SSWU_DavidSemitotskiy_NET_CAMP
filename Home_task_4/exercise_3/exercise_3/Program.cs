namespace exercise_3
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string dataLocation = @"..\..\..\..\data.txt";
            IElectricityRepository electricityRep = new ElectricityRepository(dataLocation);
            IElectricityService service = new ElectricityService(electricityRep);
            Console.WriteLine(service.QuarterApartmentInfoTableByQuarter(0, 2));
            Console.WriteLine(service.AllQuarterApartmentInfosTable());
            Console.WriteLine(service.HighestApartmentDebtTableByAllQuarters());
            Console.WriteLine(service.QuarterApartmentInfosTableWithZeroConsumptionByAllQuarters());
            Console.WriteLine(service.QuarterApartmentInfoTableByQuarter(0, 8));
            Console.WriteLine(new QuarterApartmentInfoTable());
        }
    }
}