namespace exercise_1
{
    public class AmericanExpressCardSelector : ICardSelector
    {
        public string CardType => "American Express";

        public bool IsThisType(string card)
        {
            if (card.Length != 15)
            {
                return false;
            }

            if (!card.StartsWith("34") && !card.StartsWith("37"))
            {
                return false;
            }

            return true;
        }
    }
}