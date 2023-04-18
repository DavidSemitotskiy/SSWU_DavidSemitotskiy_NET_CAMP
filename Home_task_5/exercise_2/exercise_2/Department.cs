namespace exercise_2
{
    public class Department
    {
        private List<Department> _enclosedDepartments = new List<Department>();

        private List<Product> _departmentProducts = new List<Product>();

        private string _departmentName;

        private string _previousDepartmentName;

        private bool _isMainDepartment = false;

        public Department(string previousDepartmentName, string departmentName, bool isMainDepartment = false)
        {
            _departmentName = departmentName;
            _isMainDepartment = isMainDepartment;
            _previousDepartmentName = previousDepartmentName;
        }

        public string PreviousDepartmentName => _previousDepartmentName;

        public bool IsMainDepartment => _isMainDepartment;

        public string DepartmentName => _departmentName;

        public string FullDepartmentLocation => $"{_previousDepartmentName}/{_departmentName}";

        public List<Product> Products => _departmentProducts;

        public List<Department> EnclosedDepartments => _enclosedDepartments;

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