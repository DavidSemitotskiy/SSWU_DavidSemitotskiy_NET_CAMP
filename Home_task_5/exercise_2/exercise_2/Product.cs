namespace exercise_2
{
    public class Product
    {
        private int _height;

        private int _width;

        private string _productName;

        private string _location;

        private Department _department;

        public Product(int height, int width, string name, string location, Department department)
        {
            _height = height;
            _width = width;
            _productName = name;
            _location = location;
            _department = department;
        }

        public string ProductName => _productName;

        public Department Department => _department;

        public string Location => _location;

        public int Height => _height;

        public int Width => _width;

        public string Name => _productName;
    }
}