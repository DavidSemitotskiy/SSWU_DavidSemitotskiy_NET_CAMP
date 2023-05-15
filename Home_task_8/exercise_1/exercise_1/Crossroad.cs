using System.Text;

namespace exercise_1
{
    public class Crossroad
    {
        private IEnumerable<Road> _roads;

        public Crossroad(IRoadsFactory roadsFactory)
        {
            _roads = roadsFactory.CreateRoads();
        }

        public string GetState()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var road in _roads)
            {
                sb.Append($"{road.GetState()} ");
            }

            return sb.ToString();
        }
    }
}