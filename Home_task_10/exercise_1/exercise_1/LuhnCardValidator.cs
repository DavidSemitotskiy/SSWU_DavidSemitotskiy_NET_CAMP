namespace exercise_1
{
    public class LuhnCardValidator : ICardValidator
    {
        private List<ICardSelector> _cardSelectors = new List<ICardSelector>
        {
            new AmericanExpressCardSelector(),
            new MasterCardSelector(),
            //new VisaCardSelector()
        };

        public LuhnCardValidator()
        {
        }

        public LuhnCardValidator(IEnumerable<ICardSelector> cardSelectors)
        {
            _cardSelectors = new List<ICardSelector>(cardSelectors);
        }

        public CardValidationResult ValidateCard(string card)
        {
            string cardWithoutSpaces = card.Replace(" ", "");
            if (!long.TryParse(cardWithoutSpaces, out long cardNumeric))
            {
                return CardValidationResult.CreateNotValidCardResult(card);
            }

            bool isCardSelected = false;
            ICardSelector convenientSelector = null;
            for (int i = 0; i < _cardSelectors.Count; i++)
            {
                isCardSelected = _cardSelectors[i].IsThisType(cardWithoutSpaces);
                if (isCardSelected)
                {
                    convenientSelector = _cardSelectors[i];
                    break;
                }
            }

            if (convenientSelector == null)
            {
                return CardValidationResult.CreateNotValidCardResult(card);
            }


            return IsValidCardLuhn(cardWithoutSpaces) ? CardValidationResult.CreateValidCardResult(card, convenientSelector.CardType)
                : CardValidationResult.CreateNotValidCardResult(card);
        }

        private bool IsValidCardLuhn(string card)
        {
            var cardNumbers = card.Select(symbol => (int)char.GetNumericValue(symbol)).ToList();
            int indexSymbol = 1;
            List<int> evenIndexes = new List<int>();
            List<int> oddValues = new List<int>();
            for (int i = 0; i < cardNumbers.Count(); i++, indexSymbol++)
            {
                if (indexSymbol % 2 != 0)
                {
                    oddValues.Add(cardNumbers[i]);
                    continue;
                }

                evenIndexes.Add(i);
            }

            var doubleOddValues = oddValues.Select(oddValue =>
            {
                int multipliedOddValue = oddValue * 2;
                if (multipliedOddValue >= 10)
                {
                    int secondNumber = multipliedOddValue % 10;
                    int firstNumber = (multipliedOddValue / 10) % 10;
                    multipliedOddValue = secondNumber + firstNumber;
                }

                return multipliedOddValue;
            });

            int sum = doubleOddValues.Sum();
            for (int i = 0; i < evenIndexes.Count(); i++)
            {
                sum += cardNumbers[evenIndexes[i]];
            }

            return sum % 10 == 0;
        }
    }
}