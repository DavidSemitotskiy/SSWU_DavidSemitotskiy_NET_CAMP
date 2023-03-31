namespace exercise
{
    public class WaterTower
    {
        private readonly double _maxWaterLevel;

        private double _currentLevel;

        private Pump _pump;

        public WaterTower(double maxWaterLevel, Pump pump)
        {
            var validationResult = WaterValidator.Validate(maxWaterLevel);
            if (!validationResult.Success)
            {
                throw new ArgumentException(validationResult.Description);
            }

            _currentLevel = _maxWaterLevel = maxWaterLevel;
            _pump = pump;
        }
    }
}