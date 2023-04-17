namespace exercise_3
{
    public class QuarterInfo
    {
        private int _quarterNumber;

        private decimal _consumptionPrice;

        private QuarterApartmentInfo[] _quarterApartmentInfos;

        public QuarterInfo(int quarterNumber, decimal consumptionPrice, QuarterApartmentInfo[] quarterApartmentInfos)
        {
            _quarterNumber = quarterNumber;
            _quarterApartmentInfos = quarterApartmentInfos;
            _consumptionPrice = consumptionPrice;
        }

        public IReadOnlyCollection<QuarterApartmentInfo> QuarterApartmentInfos => _quarterApartmentInfos;

        public int QuarterNumber => _quarterNumber;

        public decimal ConsumptionPrice => _consumptionPrice;
    }
}