namespace exercise_1
{
    public class TrafficLight : ITrafficLight
    {
        protected string _name;

        protected TrafficLightState _state;

        protected TrafficLightTimeInfo _timeInfo;

        protected int _counterToSwitchTrafficLightState = 0;

        protected TrafficLightState _previousTrafficLightStateForYellow;

        public TrafficLight(string name, TrafficLightTimeInfo timeInfo, TrafficLightState initialState = TrafficLightState.Yellow)
        {
            _name = name;
            _state = initialState;
            _timeInfo = timeInfo;
        }

        public string Name
        {
            get => _name;
        }

        public virtual object Clone()
        {
            return new TrafficLight(_name, _timeInfo, _state);
        }

        public virtual void SwitchState()
        {
            ++_counterToSwitchTrafficLightState;
            if ((_state == TrafficLightState.Red && _counterToSwitchTrafficLightState == _timeInfo.TimeForRedColour)
                || (_state == TrafficLightState.Green && _counterToSwitchTrafficLightState == _timeInfo.TimeForGreenColour))
            {
                _previousTrafficLightStateForYellow = _state;
                _state = TrafficLightState.Yellow;
                _counterToSwitchTrafficLightState = 0;
            }
            else if (_state == TrafficLightState.Yellow && _counterToSwitchTrafficLightState == _timeInfo.TimeForYellowColour)
            {
                if (_previousTrafficLightStateForYellow == TrafficLightState.Red)
                {
                    _state = TrafficLightState.Green;
                }
                else
                {
                    _state = TrafficLightState.Red;
                }

                _counterToSwitchTrafficLightState = 0;
            }
        }

        public override string ToString()
        {
            return $"State of {_name} traffic light: {_state}";
        }
    }
}