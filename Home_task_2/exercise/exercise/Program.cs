namespace exercise
{
    public class Program
    {
        public static void Main()
        {
            Pump pump = new Pump(45);
            WaterTower waterTower = new WaterTower(134, pump);
            ConsoleMessageLogger consoleMessageLogger = new ConsoleMessageLogger();
            Simulator simulator = new Simulator(new List<Consumer>
            {
                new Consumer(21),
                new Consumer(32),
                new Consumer(154)
            }, waterTower, consoleMessageLogger);

            for (int i = 0; i < 10; i++)
            {
                simulator.Consume();
            }
        }
    }
}