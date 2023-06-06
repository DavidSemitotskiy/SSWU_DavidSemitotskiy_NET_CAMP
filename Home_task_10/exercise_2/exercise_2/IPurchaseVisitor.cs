namespace exercise_2
{
    public interface IPurchaseVisitor
    {
        decimal Visit(ElectricityProduct electricityProduct);

        decimal Visit(EatProduct eatProduct);
    }
}