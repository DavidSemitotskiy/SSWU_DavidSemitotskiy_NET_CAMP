namespace exercise_2
{
    public class Department
    {
        private List<Department> _enclosedDepartments = new List<Department>();

        private List<Product> _departmentProducts = new List<Product>();

        private string _departmentName;

        private bool _isMainDepartment = false;

        public Department(string departmentName, bool isMainDepartment)
        {
            _departmentName = departmentName;
            _isMainDepartment = isMainDepartment;
        }

        public void AddProduct(Product product)
        {
            if (_isMainDepartment)
            {
                throw new Exception("Can't add product to main department. Choose enclosed department to do this operation");
            }

            _departmentProducts.Add(product);
        }

        public void AddEnclosedDepartment(Department department)
        {
            _enclosedDepartments.Add(department);
        }
    }
}