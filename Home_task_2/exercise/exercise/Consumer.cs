namespace exercise
{
    public class Consumer
    {
        private readonly Guid _id;

        private double _consumingWater;

        public Consumer(double consumingWater)
        {
            var validationResult = WaterValidator.Validate(consumingWater);
            if (!validationResult.Success)
            {
                throw new ArgumentException(validationResult.Description);
            }

            _consumingWater = consumingWater;
            _id = Guid.NewGuid();
        }

        public Guid Id
        {
            get { return _id; }
        }

        public double ConsumingWater
        {
            get => _consumingWater;
            set 
            {
                var validationResult = WaterValidator.Validate(value);
                if (!validationResult.Success)
                {
                    throw new ArgumentException(validationResult.Description);
                }

                _consumingWater = value; 
            }
        }

        public override string ToString()
        {
            return $"Consuming - {_consumingWater}";
        }
    }
}