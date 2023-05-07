namespace exercise
{
    public class TrafficLight
    {
        private string _name;

        private TrafficLightState _state;

        public TrafficLight(string name, TrafficLightState initialState = TrafficLightState.Red)
        {
            _name = name;
            _state = initialState;
        }

        public void SwitchState()
        {
            int numericState = (int)_state;
            _state = numericState >= (int)TrafficLightState.Green ? TrafficLightState.Red : (TrafficLightState)(++numericState);
        }

        public override string ToString()
        {
            return $"State of {_name} traffic light: {_state}";
        }
    }
}