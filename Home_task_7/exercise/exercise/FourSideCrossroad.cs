namespace exercise
{
    public class FourSideCrossroad : Crossroad
    {
        private TrafficLight _northTrafficLight;

        private TrafficLight _southTrafficLight;

        private TrafficLight _westTrafficLight;

        private TrafficLight _eastTrafficLight;

        public FourSideCrossroad(TimeSpan switchTime, Action<string>? logMessageTo = null) : base(switchTime, logMessageTo)
        {
            _northTrafficLight = new TrafficLight("North traffic light");
            _southTrafficLight = new TrafficLight("South traffic light");
            _westTrafficLight = new TrafficLight("West traffic light", TrafficLightState.Green);
            _eastTrafficLight = new TrafficLight("East traffic light", TrafficLightState.Green);
        }

        protected override void SwitchStateTrafficLights(object _)
        {
            _northTrafficLight.SwitchState();
            _southTrafficLight.SwitchState();
            _westTrafficLight.SwitchState();
            _eastTrafficLight.SwitchState();
            OnLogOccured(ToString());
        }

        public override string ToString()
        {
            return $@"Crossroad State:
                {_northTrafficLight},
                {_southTrafficLight},
                {_eastTrafficLight},
                {_westTrafficLight}";
        }
    }
}