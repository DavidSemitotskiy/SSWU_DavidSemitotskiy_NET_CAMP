namespace exercise_1
{
    public class Program
    {
        public static void Main()
        {
            //я максимально заплутався з цим завданням
            TrafficLightTimeInfo trafficLightTimeInfo1 = new TrafficLightTimeInfo(4, 2, 2);
            TrafficLightTimeInfo trafficLightTimeInfo2 = new TrafficLightTimeInfo(4, 2, 2);
            TrafficLightTimeInfo trafficLightTimeInfo3 = new TrafficLightTimeInfo(4, 2, 2);
            TrafficLightTimeInfo trafficLightTimeInfo4 = new TrafficLightTimeInfo(4, 2, 2);
            IRoadsFactory factory1 = new DefaultFourSideRoadFactory(trafficLightTimeInfo1, trafficLightTimeInfo2);
            IRoadsFactory factory2 = new DefaultFourSideRoadFactory(trafficLightTimeInfo3, trafficLightTimeInfo4);
            ICrossroadsFactory crossroadsFactory1 = new TwoFourSideLinkedCrossroadsFactory(factory1, factory2);
            Simulator simulator = new Simulator(crossroadsFactory1);
            simulator.SwitchedStateTrafficLights += message => Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}