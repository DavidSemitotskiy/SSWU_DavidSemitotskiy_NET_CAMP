namespace exercise_3
{
    public interface IElectricityRepository
    {
        public QuarterInfo[] GetAllInfo();

        public QuarterInfo GetQuarterInfoByNumber(int quarterNumber);

        public QuarterApartmentInfo FindApartmentWithHighestDebtInAllQuarters();

        public QuarterApartmentInfo[] FindApartmentsWithZeroConsumptionInAllQuarters();

        public QuarterApartmentInfo[] GetInfoForApartmentInAllQuarters(int apartmentId);

        public QuarterApartmentInfo GetInfoForApartmentByQuarter(int apartmentId, int quarterNumber);
    }
}