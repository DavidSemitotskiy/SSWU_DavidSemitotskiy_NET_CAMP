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

        public List<Department> Departments => _departments;

        public List<Product> AvailableProducts()
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < _departments.Count; i++)
            {
                products.AddRange(ProductDepartmentHierarchy(_departments[i]));
            }

            return products;
        }

        public ShopBox BuyProducts(params Product[] products)
        {
            List<DepartmentBox> departmentBoxes = new List<DepartmentBox>();
            List<ProductBox> boxes;
            var departments = products.GroupBy(product => product.Location);
            foreach (var department in departments)
            {
                boxes = new List<ProductBox>();
                foreach (var product in department)
                {
                    boxes.Add(new ProductBox(product));
                }

                departmentBoxes.Add(new DepartmentBox(boxes));
            }

            return new ShopBox(departmentBoxes);
        }

        private List<Product> ProductDepartmentHierarchy(Department department)
        {
            if (department.IsMainDepartment)
            {
                List<Product> products = new List<Product>();
                for (int i = 0; i < department.EnclosedDepartments.Count; i++)
                {
                    products.AddRange(ProductDepartmentHierarchy(department.EnclosedDepartments[i]));
                }

                return products;
            }

            return department.Products;
        }
    }
}