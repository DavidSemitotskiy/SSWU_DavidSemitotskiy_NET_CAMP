namespace exercise_3
{
    public class Program
    {// Форматування добре. Але не перевіряється, чи кінцевий показник є >=за попередній
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string dataLocation = @"..\..\..\..\data.txt";
            IElectricityRepository electricityRep = new ElectricityRepository(dataLocation);
            IElectricityService service = new ElectricityService(electricityRep);
            //виведення інформації о електроенергії за всі квартали по всім квартирам
            Console.WriteLine(service.AllQuarterApartmentInfosTable());
            //виведення інформації о електроенергії для конкретної квартири за певний квартал
            Console.WriteLine(service.QuarterApartmentInfoTableByQuarter(0, 2));
            //найбільша заборгованість за електроенергію за усі квартали
            Console.WriteLine(service.HighestApartmentDebtTableByAllQuarters());
            //виведення інформації за усі квартири, що не споживали електроенергію по всім кварталам
            Console.WriteLine(service.QuarterApartmentInfosTableWithZeroConsumptionByAllQuarters());
            //виведення інформації о електроенергії для конкретної квартири по всім кварталам
            Console.WriteLine(service.QuarterApartmentInfoTableInAllQuarters(3));
            //виведення інформації о електроенергії для всіх квартирам по конкретному кварталу
            Console.WriteLine(service.QuarterApartmentInfosTableByQuarter(2));
        }
    }
}
