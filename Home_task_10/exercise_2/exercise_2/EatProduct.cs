namespace exercise_2
{
    public class EatProduct : IProduct
    {
        public bool IsInHurry { get; set; }

        public decimal InitialPrice { get; set; }

        public decimal Weight { get; set; }

        public decimal Size { get; set; }

        public decimal Price(IPurchaseVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}