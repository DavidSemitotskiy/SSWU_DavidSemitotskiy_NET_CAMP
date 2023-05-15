using System.Text;

namespace exercise_1
{
    public class TrafficLightWithDirection : TrafficLight
    {
        private List<MovementDirection> _movementDirections;

        private TrafficLightState _directionTrafficLight;

        private int _counterToSwitchDirectionTrafficLightState = 0;

        private int _timeForGreenLightDirection;

        private int _timeForRedLightDirection;

        public TrafficLightWithDirection(string name, TrafficLightTimeInfo timeInfo, IEnumerable<MovementDirection> movementDirections,
            int timeForGreenLightDirection, int timeForRedLightDirection, TrafficLightState initialState = TrafficLightState.Yellow)
            : base(name, timeInfo, initialState)
        {
            if (!TrafficLightTimeValidator.IsValidTime(timeForGreenLightDirection) || !TrafficLightTimeValidator.IsValidTime(timeForRedLightDirection))
            {
                throw new ArgumentException("Incorrect time");
            }

            if (movementDirections == null || movementDirections.Count() == 0)
            {
                throw new ArgumentException("Movement directions are required");
            }

            _movementDirections = new List<MovementDirection>(movementDirections);
            _timeForGreenLightDirection = timeForGreenLightDirection;
            _timeForRedLightDirection = timeForRedLightDirection;
        }

        public override object Clone()
        {
            return new TrafficLightWithDirection(_name, _timeInfo, _movementDirections,
                _timeForGreenLightDirection, _timeForRedLightDirection, _state);
        }

        public override void SwitchState()
        {
            ++_counterToSwitchDirectionTrafficLightState;
            if (_directionTrafficLight == TrafficLightState.Red && _counterToSwitchDirectionTrafficLightState == _timeForRedLightDirection)
            {
                _directionTrafficLight = TrafficLightState.Green;
                _counterToSwitchDirectionTrafficLightState = 0;
            }
            else if (_directionTrafficLight == TrafficLightState.Green && _counterToSwitchDirectionTrafficLightState == _timeForGreenLightDirection)
            {
                _directionTrafficLight = TrafficLightState.Red;
                _counterToSwitchDirectionTrafficLightState = 0;
            }

            base.SwitchState();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var direction in _movementDirections)
            {
                builder.Append($"{direction} ");
            }

            return $"{base.ToString()} - Directions: {builder} DirectionLight State: {_directionTrafficLight}";
        }
    }
}