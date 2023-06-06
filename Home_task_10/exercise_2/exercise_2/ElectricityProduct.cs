namespace exercise_2
{
    public class ElectricityProduct : IProduct
    {
        public decimal InitialPrice { get; set; }

        public decimal Weight { get; set; }

        public decimal Size { get; set; }

        public decimal Price(IPurchaseVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}