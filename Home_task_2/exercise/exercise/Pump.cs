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
    }
}