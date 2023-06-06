namespace exercise_1.CardSelectors
{
    public interface ICardSelector
    {
        string CardType { get; }

        bool IsThisType(string card);
    }
}