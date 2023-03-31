namespace exercise
{
    public class ValidationResult
    {
        private ValidationResult(bool success, string? description)
        {
            Success = success;
            Description = description;
        }

        public string? Description { get; init; }

        public bool Success { get; init; }

        public static ValidationResult CreateSuccessValidationResult(string? description = null)
        {
            return new ValidationResult(true, description);
        }

        public static ValidationResult CreateNotSuccessValidationResult(string description)
        {
            return new ValidationResult(false, description);
        }
    }
}