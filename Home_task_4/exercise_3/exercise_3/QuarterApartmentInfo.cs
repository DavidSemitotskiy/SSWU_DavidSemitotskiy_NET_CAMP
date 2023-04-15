namespace exercise_3
{
    public class QuarterApartmentInfo
    {
        private ApartmentInfo _apartment;

        private int _inputIndicator;

        private int _outputIndicator;

        private DateTime _firstQuarterMonth;

        private DateTime _secondQuarterMonth;

        private DateTime _thirdQuarterMonth;

        public QuarterApartmentInfo(ApartmentInfo apartment, int onputIndicator, int outputIndicator, DateTime firstQuarterMonth, DateTime secondQuarterMonth, DateTime thirdQuarterMonth)
        {
            _apartment = apartment;
            _inputIndicator = onputIndicator;
            _outputIndicator = outputIndicator;
            _firstQuarterMonth = firstQuarterMonth;
            _secondQuarterMonth = secondQuarterMonth;
            _thirdQuarterMonth = thirdQuarterMonth;
        }
    }
}
