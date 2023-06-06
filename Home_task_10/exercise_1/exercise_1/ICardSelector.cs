namespace exercise_1
{
    public interface ICardSelector
    {
        string CardType { get; }

        bool IsThisType(string card);
    }
}
