namespace exercise
{
    public class Consumer
    {
        private double _consumingWater;

        public Consumer(double consumingWater)
        {
            var validationResult = WaterValidator.Validate(consumingWater);
            if (!validationResult.Success)
            {
                throw new ArgumentException(validationResult.Description);
            }

            _consumingWater = consumingWater;
        }
    }
}