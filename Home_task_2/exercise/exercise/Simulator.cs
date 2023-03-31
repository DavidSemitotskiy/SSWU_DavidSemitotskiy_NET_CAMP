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
    }
}