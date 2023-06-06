using exercise_1.Helpers;

namespace exercise_1.CardValidators
{
    public interface ICardValidator
    {
        CardValidationResult ValidateCard(string card);
    }
}