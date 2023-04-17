namespace exercise_3
{
    public interface IElectricityRepository
    {
        public IEnumerable<QuarterInfo> GetAllInfo();

        public QuarterInfo GetQuarterInfoByNumber(int quarterNumber);

        public QuarterApartmentInfo FindApartmentWithHighestDebtInAllQuarters();

        public IEnumerable<QuarterApartmentInfo> FindApartmentsWithZeroConsumptionInAllQuarters();

        public IEnumerable<QuarterApartmentInfo> GetInfoForApartmentInAllQuarters(int apartmentId);

        public QuarterApartmentInfo GetInfoForApartmentByQuarter(int apartmentId, int quarterNumber);
    }
}