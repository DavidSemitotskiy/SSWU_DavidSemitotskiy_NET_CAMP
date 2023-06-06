namespace exercise_1.CardSelectors
{
    public class MasterCardSelector : ICardSelector
    {
        public string CardType => "MasterCard";

        public bool IsThisType(string card)
        {
            if (card.Length != 16)
            {
                return false;
            }

            if (!card.StartsWith("51") && !card.StartsWith("52") && !card.StartsWith("53") && !card.StartsWith("54") && !card.StartsWith("55"))
            {
                return false;
            }

            return true;
        }
    }
}