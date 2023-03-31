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

        public double CurrentLevel
        {
            get { return _currentLevel; }
        }

        public double GiveWater(double consumingWater)
        {
            double result = _currentLevel - consumingWater;
            if (result >= 0)
            {
                _currentLevel = result;
                return consumingWater;
            }

            _currentLevel = 0;
            return result;
        }

        public void TurnOnPump()
        {
            while (_currentLevel != _maxWaterLevel)
            {
                double water = _pump.FillUp();
                if (water + _currentLevel <= _maxWaterLevel)
                {
                    _currentLevel += water;
                    continue;
                }

                _currentLevel = _maxWaterLevel;
            }
        }
    }
}