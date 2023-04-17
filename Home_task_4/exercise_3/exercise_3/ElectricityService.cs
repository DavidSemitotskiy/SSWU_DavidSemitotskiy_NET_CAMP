namespace exercise_3
{
    public class ElectricityService : IElectricityService
    {
        private IElectricityRepository _repository;

        public ElectricityService(IElectricityRepository repository)
        {
            _repository = repository;
        }

        public IElectricityRepository ElectricityRepository
        {
            get => _repository;
        }

        public QuarterApartmentInfoTable HighestApartmentDebtTableByAllQuarters()
        {
            QuarterApartmentInfo highestApartmentDebt = _repository.FindApartmentWithHighestDebtInAllQuarters();
            return new QuarterApartmentInfoTable(highestApartmentDebt);
        }

        public QuarterApartmentInfoTable QuarterApartmentInfoTableByQuarter(int quarterNumber, int apartmentId)
        {
            QuarterApartmentInfo quarterApartmentInfo = _repository.GetInfoForApartmentByQuarter(apartmentId, quarterNumber);
            return new QuarterApartmentInfoTable(quarterApartmentInfo);
        }

        public QuarterApartmentInfoTable AllQuarterApartmentInfosTable()
        {
            QuarterInfo[] quarters = _repository.GetAllInfo();
            return new QuarterApartmentInfoTable(quarters.SelectMany(quarter => quarter.QuarterApartmentInfos).ToArray());
        }

        public QuarterApartmentInfoTable QuarterApartmentInfosTableWithZeroConsumptionByAllQuarters()
        {
            var infos = _repository.FindApartmentsWithZeroConsumptionInAllQuarters();
            return new QuarterApartmentInfoTable(infos);
        }
    }
}