namespace exercise_1.CardSelectors
{
    public class VisaCardSelector : ICardSelector
    {
        public string CardType => "Visa";

        public bool IsThisType(string card)
        {
            if (card.Length != 13 && card.Length != 16)
            {
                return false;
            }

            if (!card.StartsWith("4"))
            {
                return false;
            }

            return true;
        }
    }
}