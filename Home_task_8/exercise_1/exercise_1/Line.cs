namespace exercise_1
{
    public class Line : ICloneable
    {
        private ITrafficLight? _trafficLight;

        public Line(ITrafficLight? trafficLight) 
        {
            _trafficLight = trafficLight?.Clone() as ITrafficLight;
        }

        public string GetState()
        {
            _trafficLight?.SwitchState();
            return ToString();
        }

        public object Clone()
        {
            return new Line(_trafficLight);
        }

        public override string ToString()
        {
            string result = _trafficLight == null ? "TrafficLight isn't set" : _trafficLight.ToString();
            return $"Line State: {result}";
        }
    }
}