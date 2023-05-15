using System.Text;

namespace exercise_1
{
    public class Road
    {
        private List<Line> _lines;

        public Road(IEnumerable<Line> lines) 
        {
            if (lines == null || lines.Count() == 0)
            {
                throw new ArgumentException("Lines are required");
            }

            _lines = lines.Clone().ToList();
        }

        public string GetState()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var line in _lines)
            {
                sb.Append($"{line.GetState()} ");
            }

            return sb.ToString();
        }
    }
}