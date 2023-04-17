using System.Text;

namespace exercise_3
{
    public class QuarterApartmentInfoTable
    {
        private string[] _columnsNames = { "Quarter number", "Apartment number", "Owner", "Input number", "Output number", "First month",
            "Second month", "Third month", "Debt", "Time to now" };

        private List<string[]> _rows = new List<string[]>();

        private int _maxColumnLength;

        public QuarterApartmentInfoTable(params QuarterApartmentInfo[] quarterApartmentInfos)
        {
            ToUserFormatTable(quarterApartmentInfos);
            FindMaxColumnsLength();
        }

        public override string ToString()
        {
            return FormatTable();
        }

        private void ToUserFormatTable(QuarterApartmentInfo[] quarterApartmentInfos)
        {
            _rows.Add(_columnsNames);
            if (quarterApartmentInfos == null || (quarterApartmentInfos.Length == 1 && quarterApartmentInfos[0] == null))
            {
                return;
            }

            string dataFormat = "dd.MM.yy";
            TimeSpan timeToNow;
            for (int i = 0; i < quarterApartmentInfos.Length; i++)
            {
                timeToNow = DateTime.Now - quarterApartmentInfos[i].ThirdQuarterMonth;
                _rows.Add(new string[] 
                {
                    quarterApartmentInfos[i].Id.ToString(), quarterApartmentInfos[i].ApartmentInfo.Id.ToString(),
                    quarterApartmentInfos[i].ApartmentInfo.LastName, quarterApartmentInfos[i].InputIndicator.ToString(),
                    quarterApartmentInfos[i].OutputIndicator.ToString(), quarterApartmentInfos[i].FirstQuarterMonth.ToString(dataFormat),
                    quarterApartmentInfos[i].SecondQuarterMonth.ToString(dataFormat), quarterApartmentInfos[i].ThirdQuarterMonth.ToString(dataFormat),
                    quarterApartmentInfos[i].TotalPrice.ToString(), Math.Floor(timeToNow.TotalDays).ToString() 
                });
            }
        }

        private void FindMaxColumnsLength()
        {
            if (_rows.Count == 1)
            {
                _maxColumnLength = _columnsNames.MaxBy(col => col.Length).Length;
                return;
            }

            var rows = _rows.SelectMany(row => row);
            _maxColumnLength = rows.MaxBy(col => col.Length).Length;
        }

        private string FormatTable()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder headers = new StringBuilder();
            for (int i = 0; i < _rows[0].Length; i++)
            {
                headers.Append($"|{_rows[0][i].PadLeft(_maxColumnLength)}|");
            }

            string headersString = headers.ToString();
            int summaryLength = headersString.Length;
            string separator = new string('-', summaryLength);
            sb.AppendLine(separator);
            sb.AppendLine(headersString);
            sb.AppendLine(separator);
            for (int i = 1; i < _rows.Count; i++)
            {
                for (int j = 0; j < _rows[i].Length; j++)
                {
                    sb.Append($"|{_rows[i][j].PadLeft(_maxColumnLength)}|");
                }

                sb.Append("\n");
            }

            sb.AppendLine(separator);
            return sb.ToString();
        }
    }
}