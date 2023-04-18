namespace exercise_2
{
    public class Shop
    {
        private List<Department> _departments;

        private string _shopName;

        public Shop(string shopName, List<Department> departments)
        {
            _shopName = shopName;
            _departments = departments;
        }
    }
}