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

        public QuarterApartmentInfoTable QuarterApartmentInfoTableInAllQuarters(int apartmentId)
        {
            IEnumerable<QuarterApartmentInfo> quarterApartmentInfos = _repository.GetInfoForApartmentInAllQuarters(apartmentId);
            return new QuarterApartmentInfoTable(quarterApartmentInfos.ToArray());
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
            IEnumerable<QuarterInfo> quarters = _repository.GetAllInfo();
            return new QuarterApartmentInfoTable(quarters.SelectMany(quarter => quarter.QuarterApartmentInfos).ToArray());
        }

        public QuarterApartmentInfoTable QuarterApartmentInfosTableWithZeroConsumptionByAllQuarters()
        {
            IEnumerable<QuarterApartmentInfo> infos = _repository.FindApartmentsWithZeroConsumptionInAllQuarters();
            return new QuarterApartmentInfoTable(infos.ToArray());
        }

        public QuarterApartmentInfoTable QuarterApartmentInfosTableByQuarter(int quarterNumber)
        {
            QuarterInfo quarterInfo = _repository.GetQuarterInfoByNumber(quarterNumber);
            return new QuarterApartmentInfoTable(quarterInfo == null ? null : quarterInfo.QuarterApartmentInfos);
        }
    }
}