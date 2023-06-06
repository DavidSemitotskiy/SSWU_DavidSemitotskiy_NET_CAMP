namespace exercise_2
{
    public class Basket : IBasket
    {
        private List<IProduct> _products;

        public Basket(List<IProduct> products)
        {
            _products = new List<IProduct>(products);
        }

        public decimal TotalPriceOfBasket(IPurchaseVisitor visitor)
        {
            decimal totalBasketPrice = 0m;
            foreach (var product in _products)
            {
                totalBasketPrice += product.Price(visitor);
            }

            return totalBasketPrice;
        }
    }
}