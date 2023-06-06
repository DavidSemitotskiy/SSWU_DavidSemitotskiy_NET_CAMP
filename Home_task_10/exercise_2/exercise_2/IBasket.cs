namespace exercise_2
{
    public interface IBasket
    {
        decimal TotalPriceOfBasket(IPurchaseVisitor visitor);
    }
}