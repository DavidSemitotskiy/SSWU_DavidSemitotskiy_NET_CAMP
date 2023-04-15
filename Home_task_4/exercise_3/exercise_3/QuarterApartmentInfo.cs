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

        public int Id
        {
            get => _idQuarter;
        }

        public ApartmentInfo ApartmentInfo
        {
            get => _apartment;
        }

        public int InputIndicator
        {
            get => _inputIndicator;
        }

        public int OutputIndicator
        {
            get => _outputIndicator;
        }

        public DateTime FirstQuarterMonth
        {
            get => _firstQuarterMonth;
        }

        public DateTime SecondQuarterMonth
        {
            get => _secondQuarterMonth;
        }

        public DateTime ThirdQuarterMonth
        {
            get => _thirdQuarterMonth;
        }
    }
}