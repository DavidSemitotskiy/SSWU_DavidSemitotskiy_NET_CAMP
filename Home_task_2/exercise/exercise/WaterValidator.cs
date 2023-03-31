namespace exercise
{
    public static class WaterValidator
    {
        public static ValidationResult Validate(double water)
        {
            if (water <= 0)
            {
                return ValidationResult.CreateNotSuccessValidationResult("Incorrect water");
            }

            return ValidationResult.CreateSuccessValidationResult();
        }
    }
}