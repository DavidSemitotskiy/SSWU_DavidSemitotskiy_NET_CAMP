namespace exercise_2
{
    public class Program
    {
        public static void Main()
        {
            List<IProduct> products = new List<IProduct> 
            {
                new EatProduct
                {
                    InitialPrice = 143m,
                    Size = 1m,
                    IsInHurry = false,
                    Weight = 0.5m
                },
                new ElectricityProduct
                {
                    InitialPrice = 2123m,
                    Size = 13m,
                    Weight = 23m
                },
                new ElectricityProduct
                {
                    InitialPrice = 1233m,
                    Size = 11m,
                    Weight = 56m
                },
                new EatProduct
                {
                    InitialPrice = 345m,
                    Size = 0.6m,
                    IsInHurry = true,
                    Weight = 0.5m
                }
            };
            IBasket basket = new Basket(products);
            IPurchaseVisitor visitor = new PurchaseVisitor();
            Console.WriteLine(basket.TotalPriceOfBasket(visitor));
        }
    }
}