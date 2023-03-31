using System;

namespace exercise
{
    public class WaterTower : ICloneable
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
            _pump = (Pump)pump.Clone();
        }

        public double CurrentLevel
        {
            get { return _currentLevel; }
        }

        public object Clone()
        {
            return new WaterTower(_maxWaterLevel, (Pump)_pump.Clone());
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

        public override string ToString()
        {
            return $"Current water level: {_currentLevel}/{_maxWaterLevel}";
        }
    }
}