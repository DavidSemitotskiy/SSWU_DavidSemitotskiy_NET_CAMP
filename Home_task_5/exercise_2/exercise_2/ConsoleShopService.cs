namespace exercise_2
{
    public class ConsoleShopService
    {
        private Shop _shop;

        public ConsoleShopService()
        {
            _shop = CreateShop();
        }

        private Shop CreateShop()
        {
            Console.Write("Введіть назву магазину: ");
            string shopName = Console.ReadLine();
            List<Department> shopDepartments = new List<Department>();
            bool exit = false;
            while (!exit)
            {
                shopDepartments.Add(CreateDepartment(shopName));
                Console.Write("Чи бажаєте завершити додавання відділів?(True/False): ");
                exit = bool.Parse(Console.ReadLine());
            }

            return new Shop(shopName, shopDepartments);
        }

        private Department CreateDepartment(string previousDepartmentName)
        {
            Console.Write("Введіть назву відділу: ");
            string departmentName = Console.ReadLine();
            Console.Write("Чи є відділ головним(True/False): ");
            bool isMainDepartment = bool.Parse(Console.ReadLine());
            Department department = new Department(previousDepartmentName, departmentName, isMainDepartment);
            if (isMainDepartment)
            {
                Console.Write("Введіть кількість підвідділів: ");
                int countEnclosedDepartments = int.Parse(Console.ReadLine());
                for (int i = 0; i < countEnclosedDepartments; i++)
                {
                    department.AddEnclosedDepartment(CreateDepartment(department.FullDepartmentLocation));
                }

                return department;
            }

            Console.Write("Введіть кількість продуктів у відділі: ");
            int countProduct = int.Parse(Console.ReadLine());
            for (int i = 0; i < countProduct; i++)
            {
                department.AddProduct(CreateProduct(department.FullDepartmentLocation));
            }

            return department;
        }

        private Product CreateProduct(string departmentName)
        {
            Console.Write("Введіть назву продукта: ");
            string productName = Console.ReadLine();
            Console.Write("Введіть висоту продукта: ");
            int productHeigt = int.Parse(Console.ReadLine());
            Console.Write("Введіть ширину продукта: ");
            int productWidth = int.Parse(Console.ReadLine());
            string productLocation = departmentName;
            return new Product(productHeigt, productWidth, productName, productLocation);
        }
    }
}