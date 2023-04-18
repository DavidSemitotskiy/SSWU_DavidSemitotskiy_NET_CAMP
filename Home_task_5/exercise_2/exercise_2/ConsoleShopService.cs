namespace exercise_2
{
    public class ConsoleShopService
    {
        private Shop _shop;

        public ConsoleShopService()
        {
            _shop = CreateShop();
        }

        public void StartWork()
        {
            Console.WriteLine("1)Show shop hierarchy");
            Console.WriteLine("2)Buy products");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        ShowShopHierarchy();
                        break;
                    }
                case 2:
                    {
                        ShopBox purchase = Buy();
                        Console.WriteLine(purchase);
                        break;
                    }
            }
        }

        public ShopBox Buy()
        {
            List<Product> allProductsInShop = _shop.AvailableProducts();
            for (int i = 0; i < allProductsInShop.Count; i++)
            {
                Console.WriteLine($"{i + 1}){allProductsInShop[i].ProductName}");
            }

            string[] indexes = Console.ReadLine().Split(' ');
            return _shop.BuyProducts(GetBuyingProducts(allProductsInShop, indexes).ToArray());
        }

        private List<Product> GetBuyingProducts(List<Product> allProductsInShop, string[] indexes)
        {
            List<Product> productsToBuy = new List<Product>();
            for (int i = 0; i < indexes.Length; i++)
            {
                productsToBuy.Add(allProductsInShop.ElementAt(int.Parse(indexes[i]) - 1));
            }

            return productsToBuy;
        }

        private Shop CreateShop()
        {
            Console.Write("Чи бажаєте використати шаблонний магазин?(True/False): ");
            bool defaultShop = bool.Parse(Console.ReadLine());
            if (defaultShop == true)
            {
                string name = "Мій магазин";
                List<Department> departments = new List<Department>();
                Department dairyDepartment = new Department(name, "Молочний", true);
                Department meatDepartment = new Department(name, "М'ясний", true);
                Department cheeseDepartment = new Department(dairyDepartment.FullDepartmentLocation, "Сирний");
                cheeseDepartment.AddProduct(new Product(2, 5, "Пармезан", cheeseDepartment.FullDepartmentLocation, cheeseDepartment));
                Department yogurtDepartment = new Department(dairyDepartment.FullDepartmentLocation, "Кефірний");
                yogurtDepartment.AddProduct(new Product(5, 1, "Дольче", yogurtDepartment.FullDepartmentLocation, yogurtDepartment));
                dairyDepartment.AddEnclosedDepartment(cheeseDepartment);
                dairyDepartment.AddEnclosedDepartment(yogurtDepartment);
                Department sausageDepartment = new Department(meatDepartment.FullDepartmentLocation, "Ковбасний", false);
                sausageDepartment.AddProduct(new Product(2, 1, "Сосиска", sausageDepartment.FullDepartmentLocation, sausageDepartment));
                sausageDepartment.AddProduct(new Product(4, 3, "Сарделька", sausageDepartment.FullDepartmentLocation, sausageDepartment));
                meatDepartment.AddEnclosedDepartment(sausageDepartment);
                departments.Add(dairyDepartment);
                departments.Add(meatDepartment);
                return new Shop(name, departments);
            }

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

        private void ShowShopHierarchy()
        {
            for (int i = 0; i < _shop.Departments.Count; i++)
            {
                Console.WriteLine(new string('-', 20));
                ShowFullDepartment(_shop.Departments[i]);
                Console.WriteLine(new string('-', 20));
            }
        }

        private void ShowFullDepartment(Department department)
        {
            Console.WriteLine($"{department.PreviousDepartmentName}");
            if (department.IsMainDepartment)
            {
                for (int i = 0; i < department.EnclosedDepartments.Count; i++)
                {
                    ShowFullDepartment(department.EnclosedDepartments[i]);
                }

                return;
            }

            Console.WriteLine($"{department.DepartmentName}");
            Console.WriteLine("Products: ");
            for (int i = 0; i < department.Products.Count; i++)
            {
                Console.WriteLine(department.Products[i].ProductName);
            }
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
                department.AddProduct(CreateProduct(department.FullDepartmentLocation, department));
            }

            return department;
        }

        private Product CreateProduct(string departmentName, Department department)
        {
            Console.Write("Введіть назву продукта: ");
            string productName = Console.ReadLine();
            Console.Write("Введіть висоту продукта: ");
            int productHeigt = int.Parse(Console.ReadLine());
            Console.Write("Введіть ширину продукта: ");
            int productWidth = int.Parse(Console.ReadLine());
            string productLocation = departmentName;
            return new Product(productHeigt, productWidth, productName, productLocation, department);
        }
    }
}