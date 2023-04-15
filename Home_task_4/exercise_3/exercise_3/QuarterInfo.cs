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

        public QuarterApartmentInfo[] QuarterApartmentInfos
        {
            get => _quarterApartmentInfos;
        }

        public int QuarterNumber
        {
            get => _quarterNumber;
        }

        public decimal ConsumptionPrice
        {
            get => _consumptionPrice;
        }
    }
}