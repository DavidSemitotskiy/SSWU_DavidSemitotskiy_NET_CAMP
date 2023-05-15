namespace exercise_1
{
    public class DefaultFourSideRoadFactory : IRoadsFactory
    {
        private TrafficLightTimeInfo _first;

        private TrafficLightTimeInfo _second;

        public DefaultFourSideRoadFactory(TrafficLightTimeInfo first, TrafficLightTimeInfo second)
        {
            _first = first;
            _second = second;
        }

        public IEnumerable<Road> CreateRoads()
        {
            Road road1 = new Road(new List<Line> 
            { 
                new Line(new TrafficLight("North-South", _first)),
                new Line(new TrafficLightWithDirection("South-North", _first, new List<MovementDirection> { MovementDirection.Right}, _second.TimeForGreenColour, _second.TimeForRedColour))
            });

            Road road2 = new Road(new List<Line> 
            { 
                new Line(new TrafficLightWithDirection("West-East", _second, new List<MovementDirection> { MovementDirection.Right }, _first.TimeForGreenColour, _first.TimeForRedColour)),
                new Line(new TrafficLight("East-West", _second)) });

            return new List<Road> 
            {
                road1,
                road2,
            };
        }
    }
}