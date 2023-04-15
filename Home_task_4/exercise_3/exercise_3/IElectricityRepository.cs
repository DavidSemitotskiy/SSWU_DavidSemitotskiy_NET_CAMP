namespace exercise_3
{
    public interface IElectricityRepository
    {
        public QuarterInfo[] GetAllInfo();

        public QuarterInfo GetQuarterInfo(int quarterNumber);

        public QuarterApartmentInfo GetInfoForApartmentByQuarter(int apartmentId, int quarterNumber);
    }
}