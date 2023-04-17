using System.Globalization;

namespace exercise_3
{
    public class ElectricityRepository : IElectricityRepository
    {
        private QuarterInfo[] _quarterInfos;

        private int _quarterCountInYear = 4;

        private string _dataLocation;

        public ElectricityRepository(string dataLocation)
        {
            _dataLocation = dataLocation;
            LoadDataFromSource();
        }

        public IEnumerable<QuarterInfo> GetAllInfo()
        {
            return _quarterInfos;
        }

        public QuarterInfo GetQuarterInfoByNumber(int quarterNumber)
        {
            if (quarterNumber > _quarterCountInYear || quarterNumber < 0)
            {
                return null;
            }

            return _quarterInfos[quarterNumber];
        }

        public QuarterApartmentInfo FindApartmentWithHighestDebtInAllQuarters()
        {
            return _quarterInfos.SelectMany(quarterInfo => quarterInfo.QuarterApartmentInfos).MaxBy(quarterApartmentInfo => quarterApartmentInfo.TotalPrice);
        }

        public IEnumerable<QuarterApartmentInfo> FindApartmentsWithZeroConsumptionInAllQuarters()
        {
            return _quarterInfos.SelectMany(quarterInfo => quarterInfo.QuarterApartmentInfos).Where(quarterApartmentInfo => quarterApartmentInfo.OutputIndicator == 0);
        }

        public IEnumerable<QuarterApartmentInfo> GetInfoForApartmentInAllQuarters(int apartmentId)
        {
            return _quarterInfos.SelectMany(quarterInfo => quarterInfo.QuarterApartmentInfos).Where(quarterApartmentInfo => quarterApartmentInfo.ApartmentInfo.Id == apartmentId);
        }

        public QuarterApartmentInfo GetInfoForApartmentByQuarter(int apartmentId, int quarterNumber)
        {
            if (quarterNumber > _quarterCountInYear || quarterNumber < 0)
            {
                return null;
            }

            QuarterInfo quarter = _quarterInfos[quarterNumber];
            return quarter.QuarterApartmentInfos.FirstOrDefault(quarterApartmentInfo => quarterApartmentInfo.ApartmentInfo.Id == apartmentId);
        }

        private void LoadDataFromSource()
        {
            using (StreamReader streamReader = new StreamReader(_dataLocation))
            {
                _quarterInfos = new QuarterInfo[_quarterCountInYear];
                for (int i = 0; i < _quarterInfos.Length; i++)
                {
                    string lineQuarterInfo = streamReader.ReadLine();
                    string[] info = lineQuarterInfo.Split("; ");
                    int countApartments = int.Parse(info[0]);
                    int quarterNumber = int.Parse(info[1]);
                    NumberFormatInfo numberFormatInfo = new NumberFormatInfo
                    {
                        NumberDecimalSeparator = "."
                    };
                    decimal consumptionPrice = decimal.Parse(info[2], numberFormatInfo);
                    QuarterApartmentInfo[] quarterApartmentInfos = new QuarterApartmentInfo[countApartments];
                    int j = 0;
                    while (j < quarterApartmentInfos.Length)
                    {
                        string strQuarterApartmentInfo = streamReader.ReadLine();
                        string[] strQuarterApartmentInfoParts = strQuarterApartmentInfo.Split("; ");
                        ApartmentInfo apartmentInfo = new ApartmentInfo(int.Parse(strQuarterApartmentInfoParts[0]), strQuarterApartmentInfoParts[1], strQuarterApartmentInfoParts[2]);
                        quarterApartmentInfos[j] = new QuarterApartmentInfo(quarterNumber, consumptionPrice, apartmentInfo,
                            int.Parse(strQuarterApartmentInfoParts[3]), int.Parse(strQuarterApartmentInfoParts[4]),
                            DateTime.Parse(strQuarterApartmentInfoParts[5]), DateTime.Parse(strQuarterApartmentInfoParts[6]),
                            DateTime.Parse(strQuarterApartmentInfoParts[7]));
                        j++;
                    }

                    _quarterInfos[i] = new QuarterInfo(quarterNumber, consumptionPrice, quarterApartmentInfos); 
                }
            }
        }
    }
}