namespace exercise_3
{
    public class QuarterApartmentInfo
    {
        private int _idQuarter;

        private decimal _totalPrice;

        private ApartmentInfo _apartment;

        private int _inputIndicator;

        private int _outputIndicator;

        private DateTime _firstQuarterMonth;

        private DateTime _secondQuarterMonth;

        private DateTime _thirdQuarterMonth;

        public QuarterApartmentInfo(int idQuarter, decimal consumptionPrice, ApartmentInfo apartment,
            int onputIndicator, int outputIndicator, DateTime firstQuarterMonth,
            DateTime secondQuarterMonth, DateTime thirdQuarterMonth)
        {
            _apartment = apartment;
            _inputIndicator = onputIndicator;
            _outputIndicator = outputIndicator;
            _firstQuarterMonth = firstQuarterMonth;
            _secondQuarterMonth = secondQuarterMonth;
            _thirdQuarterMonth = thirdQuarterMonth;
            _idQuarter = idQuarter;
            _totalPrice = consumptionPrice * outputIndicator;
        }

        public int Id => _idQuarter;

        public ApartmentInfo ApartmentInfo => _apartment;

        public int InputIndicator => _inputIndicator;

        public int OutputIndicator => _outputIndicator;

        public DateTime FirstQuarterMonth => _firstQuarterMonth;

        public DateTime SecondQuarterMonth => _secondQuarterMonth;

        public DateTime ThirdQuarterMonth => _thirdQuarterMonth;

        public decimal TotalPrice => _totalPrice;
    }
}