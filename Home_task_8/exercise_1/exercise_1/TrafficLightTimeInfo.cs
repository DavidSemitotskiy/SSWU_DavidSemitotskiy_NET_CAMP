namespace exercise_1
{
    public class TrafficLightTimeInfo
    {
        public TrafficLightTimeInfo(int timeForGreenColour, int timeForRedColour, int timeForYellowColour)
        {
            if (!TrafficLightTimeValidator.IsValidTrafficLightTime(timeForGreenColour, timeForRedColour, timeForYellowColour))
            {
                throw new ArgumentException("Incorrect TrafficLightTimeInfo");
            }

            TimeForGreenColour = timeForGreenColour;
            TimeForRedColour = timeForRedColour;
            TimeForYellowColour = timeForYellowColour;
        }

        public int TimeForGreenColour { get; }

        public int TimeForRedColour { get; }

        public int TimeForYellowColour { get; }
    }
}