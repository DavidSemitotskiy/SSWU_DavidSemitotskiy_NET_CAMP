namespace exercise
{
    public class Simulator
    {
        private List<Consumer> _consumers;

        private WaterTower _waterTower;

        private IMessageLogger _messageLogger;

        public Simulator(List<Consumer> consumers, WaterTower waterTower, IMessageLogger messageLogger)
        {
            _consumers = consumers;
            _waterTower = waterTower;
            _messageLogger = messageLogger;
        }

        public void Consume()
        {
            for (int i = 0; i < _consumers.Count; i++)
            {
                ConsumeWater(_consumers[i].Id, _consumers[i].ConsumingWater);
                _messageLogger.Log($"Consumer totally consumed: {_consumers[i].ConsumingWater}", "Simulator");
            }
        }

        private void ConsumeWater(Guid id, double consumingWater)
        {
            _messageLogger.Log($"Current water level: {_waterTower.CurrentLevel}", "WaterTower");
            _messageLogger.Log($"Consumer {id} is trying to consume: {consumingWater}", "Simulator");
            double consumedWater = _waterTower.GiveWater(consumingWater);
            if (consumedWater < 0)
            {
                _messageLogger.Log($"Lack of water: {Math.Abs(consumedWater)}", "Simulator");
                _messageLogger.Log("Turning on Pump", "WaterTower");
                _waterTower.TurnOnPump();
                _messageLogger.Log("Turning off Pump", "WaterTower");
                ConsumeWater(id, Math.Abs(consumedWater));
            }
            else
            {
                _messageLogger.Log($"Consumer {id} consumed: {consumingWater}", "Simulator");
            }
        }
    }
}