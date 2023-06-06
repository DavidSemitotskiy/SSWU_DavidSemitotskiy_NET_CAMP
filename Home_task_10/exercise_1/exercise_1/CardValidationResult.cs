namespace exercise_1
{
    public class CardValidationResult
    {
        public CardValidationResult(bool isValid, CardValidatedState cardValidatedState, string validatedCard, string? typeCard = null)
        {
            IsValid = isValid;
            TypeCard = typeCard;
            ValidatedCard = validatedCard;
            CardValidatedState = cardValidatedState;
        }

        public string? TypeCard { get; }

        public bool IsValid { get; }

        public CardValidatedState CardValidatedState { get; }

        public string ValidatedCard { get; }

        public override string ToString()
        {
            string resultString = $"Is Valid - {IsValid}; Validated Card - {ValidatedCard}; Card Validated State - {CardValidatedState};";
            if (TypeCard != null)
            {
                resultString = resultString + $" Type Card - {TypeCard}";
            }

            return resultString;
        }
    }
}