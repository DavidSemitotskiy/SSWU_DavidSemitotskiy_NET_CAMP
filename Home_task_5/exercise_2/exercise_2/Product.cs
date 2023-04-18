namespace exercise_2
{
    public class Product
    {
        private int _height;

        private int _width;

        private string _productName;

        private string _location;

        public Product(int height, int width, string name, string location)
        {
            _height = height;
            _width = width;
            _productName = name;
            _location = location;
        }
    }
}