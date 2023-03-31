namespace exercise
{
    public class Pump
    {
        private readonly double _fillingPower;

        public Pump(double fillingPower)
        {
            var validationResult = WaterValidator.Validate(fillingPower);
            if (!validationResult.Success)
            {
                throw new ArgumentException(validationResult.Description);
            }

            _fillingPower = fillingPower;
        }

        public double FillUp()
        {
            return _fillingPower;
        }

        public override string ToString()
        {
            return $"Pump power - {_fillingPower}";
        }
    }
}