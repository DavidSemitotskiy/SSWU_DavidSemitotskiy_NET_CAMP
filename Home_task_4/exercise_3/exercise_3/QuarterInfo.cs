namespace exercise_3
{
    public class QuarterInfo
    {
        private int _quarterNumber;

        private QuarterApartmentInfo[] _quarterApartmentInfos;

        public QuarterInfo(int quarterNumber, QuarterApartmentInfo[] quarterApartmentInfos)
        {
            _quarterNumber = quarterNumber;
            _quarterApartmentInfos = quarterApartmentInfos;
        }
    }
}
