namespace exercise
{
    public abstract class Crossroad
    {
        protected Timer timer;

        public event Action<string> SwitchedStateTrafficLights;

        public Crossroad(TimeSpan switchTime, Action<string>? logMessageTo = null)
        {
            SwitchedStateTrafficLights = logMessageTo ?? Console.WriteLine;
            timer = new Timer(SwitchStateTrafficLights, null, TimeSpan.Zero, switchTime);
        }

        protected void OnLogOccured(string message)
        {
            SwitchedStateTrafficLights?.Invoke(message);
        }

        protected abstract void SwitchStateTrafficLights(object _);
    }
}