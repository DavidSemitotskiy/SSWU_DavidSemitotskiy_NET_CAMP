namespace exercise_2
{
    public interface IProduct
    {
        public decimal Weight { get; set; }

        public decimal Size { get; set; }

        public decimal InitialPrice { get; set; }

        decimal Price(IPurchaseVisitor visitor);
    }
}