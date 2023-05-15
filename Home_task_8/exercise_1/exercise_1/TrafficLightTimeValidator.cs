namespace exercise_1
{
    public static class TrafficLightTimeValidator
    {
        public static bool IsValidTime(int time)
        {
            return !(time < 1);
        }

        public static bool IsValidTrafficLightTime(int timeForGreenColour, int timeForRedColour, int timeForYellowColour)
        {
            return IsValidTime(timeForGreenColour) && IsValidTime(timeForRedColour) && IsValidTime(timeForYellowColour);
        }
    }
}