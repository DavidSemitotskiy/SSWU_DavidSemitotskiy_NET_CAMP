namespace exercise_2
{
    public class DepartmentBox
    {
        private List<ProductBox> _productBoxes;

        private int _totalHeight;

        private int _totalWidth;

        public DepartmentBox(List<ProductBox> productBoxes)
        {
            _productBoxes = productBoxes;
            _totalHeight = productBoxes.Sum(box => box.Height);
            _totalWidth = productBoxes.MaxBy(box => box.Width).Width;
        }

        public int Height => _totalHeight;

        public int Width => _totalWidth;

        public List<ProductBox> ProductBoxes => _productBoxes;
    }
}
