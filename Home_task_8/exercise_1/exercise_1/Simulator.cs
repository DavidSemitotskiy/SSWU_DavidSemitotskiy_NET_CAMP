namespace exercise_1
{
    public class Simulator
    {
        private IEnumerable<Crossroad> _crossroads;

        public event Action<string> SwitchedStateTrafficLights;

        private Timer _trafficLightStateSwitcher;

        public Simulator(ICrossroadsFactory crossroadsFactory)
        {
            _crossroads = crossroadsFactory.CreateLinkedCrossroads();
            _trafficLightStateSwitcher = new Timer(SwitchStatesOfCrossroadsTrafficLights, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        private void SwitchStatesOfCrossroadsTrafficLights(object? state)
        {
            string crossroadState;
            int number = 0;
            foreach (var crossroad in _crossroads)
            {
                crossroadState = crossroad.GetState();
                SwitchedStateTrafficLights?.Invoke($"{DateTime.Now} Crossroad State {number} - {crossroadState}");
                number++;
            }
        }
    }
}