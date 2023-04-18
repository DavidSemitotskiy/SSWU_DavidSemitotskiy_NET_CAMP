using System.Text;

namespace exercise_2
{
    public class ShopBox
    {
        private List<DepartmentBox> _departmentBoxes;

        private int _totalHeight;

        private int _totalWidth;

        public ShopBox(List<DepartmentBox> departmentBoxes)
        {
            _departmentBoxes = departmentBoxes;
            _totalHeight = departmentBoxes.Sum(box => box.Height);
            _totalWidth = departmentBoxes.MaxBy(box => box.Width).Width;
        }

        public int Height => _totalHeight;

        public int Width => _totalWidth;

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Purchase height - {_totalHeight}; Purchase width - {_totalWidth}");
            builder.AppendLine("Contains: ");
            for (int i = 0; i < _departmentBoxes.Count; i++)
            {
                for (int j = 0; j < _departmentBoxes[i].ProductBoxes.Count; j++)
                {
                    builder.AppendLine($"#{_departmentBoxes[i].ProductBoxes[j].Location}/{_departmentBoxes[i].ProductBoxes[j].Name}");
                }
            }

            return builder.ToString();
        }
    }
}
