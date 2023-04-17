namespace exercise_3
{
    public interface IElectricityService
    {
        public QuarterApartmentInfoTable HighestApartmentDebtTableByAllQuarters();

        public QuarterApartmentInfoTable QuarterApartmentInfoTableByQuarter(int quarterNumber, int apartmentId);

        public QuarterApartmentInfoTable AllQuarterApartmentInfosTable();

        public QuarterApartmentInfoTable QuarterApartmentInfosTableWithZeroConsumptionByAllQuarters();

        public QuarterApartmentInfoTable QuarterApartmentInfoTableInAllQuarters(int apartmentId);

        public QuarterApartmentInfoTable QuarterApartmentInfosTableByQuarter(int quarterNumber);
    }
}