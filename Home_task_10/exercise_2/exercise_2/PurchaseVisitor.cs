namespace exercise_2
{
    public class PurchaseVisitor : IPurchaseVisitor
    {
        private decimal _priceByOneKg = 2.5m;

        private decimal _priceByOneMeter = 0.2m;

        public decimal Visit(ElectricityProduct electricityProduct)
        {
            decimal priceByWeight = CountPriceByWeight(electricityProduct);
            decimal priceBySize = CountPriceBySize(electricityProduct);

            if (electricityProduct.Weight > 40) 
            {
                priceByWeight = priceByWeight * 1.25m;
            }

            decimal totalPrice = electricityProduct.InitialPrice + priceByWeight * priceBySize;
            return totalPrice;
        }

        public decimal Visit(EatProduct eatProduct)
        {
            decimal priceByWeight = CountPriceByWeight(eatProduct);
            decimal priceBySize = CountPriceBySize(eatProduct);
            decimal totalPrice = 0;
            if (eatProduct.IsInHurry)
            {
                totalPrice += 100;
            }

            totalPrice += priceByWeight + priceBySize + eatProduct.InitialPrice;
            return totalPrice;
        }

        public decimal CountPriceByWeight(IProduct product)
        {
            return product.Weight * _priceByOneKg;
        }

        public decimal CountPriceBySize(IProduct product)
        {
            return product.Size * _priceByOneMeter;
        }
    }
}