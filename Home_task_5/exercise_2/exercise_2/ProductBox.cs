namespace exercise_2
{
    public class ProductBox
    {
        private int _height;

        private int _width;

        private string _location;

        private string _name;

        public ProductBox(Product product)
        {
            _height = product.Height;
            _width = product.Width;
            _location = product.Location;
            _name = product.Name;
        }

        public string Location => _location;

        public int Height => _height;

        public int Width => _width;

        public string Name => _name;
    }
}
