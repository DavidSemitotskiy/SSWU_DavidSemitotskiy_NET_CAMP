namespace exercise_1
{
    public class CardValidationResult
    {
        public CardValidationResult(bool isValid, string validatedCard, string? typeCard = null)
        {
            IsValid = isValid;
            TypeCard = typeCard;
            ValidatedCard = validatedCard;
        }

        public string? TypeCard { get; }

        public bool IsValid { get; }

        public string ValidatedCard { get; }

        public static CardValidationResult CreateValidCardResult(string validatedCard, string typeCard)
        {
            return new CardValidationResult(true, validatedCard, typeCard);
        }

        public static CardValidationResult CreateNotValidCardResult(string validatedCard)
        {
            return new CardValidationResult(false, validatedCard, null);
        }

        public override string ToString()
        {
            return $"Is Valid - {IsValid}; Type Card - {TypeCard ?? "Unknown"}; Validated Card - {ValidatedCard}";
        }
    }
}