using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Computer" },
                new Category{CategoryId=2, CategoryName="Electronics" },
            };
            List<Product> products = new List<Product>()
            {
                new Product { ProductId=1,CategoryId=1,ProductName="Huawei Matebook",QuantityPerUnit="16 GB Ram",UnitPrice=40000,UnitsInStock=7},
                new Product { ProductId=2,CategoryId=1,ProductName="Asus",QuantityPerUnit="32 GB Ram",UnitPrice=43000,UnitsInStock=12},
                new Product { ProductId=3,CategoryId=1,ProductName="Hp",QuantityPerUnit="16 GB Ram",UnitPrice=44000,UnitsInStock=6},
                new Product { ProductId=4,CategoryId=2,ProductName="Huawei",QuantityPerUnit="8 GB Ram",UnitPrice=22000,UnitsInStock=2},
                new Product { ProductId=5,CategoryId=2,ProductName="Xiaomi",QuantityPerUnit="4 GB Ram",UnitPrice=14000,UnitsInStock=0},
            };



            var result = products.Where(p => p.UnitPrice > 20000 && p.UnitsInStock > 5);

            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

            ////
            Console.WriteLine("---------------");

            Console.WriteLine("Enter minimum unit price: ");
            decimal minUnitPrice = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter minimum stock quantity: ");
            int minStockQuantity = Convert.ToInt32(Console.ReadLine());

            var filteredProducts = products.Where(p => p.UnitPrice > minUnitPrice && p.UnitsInStock > minStockQuantity);

            Console.WriteLine("Filtered Products:");
            foreach (var item in filteredProducts)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("Choose a product:");
            string selectedProductName = Console.ReadLine();

            var selectedProduct = products.FirstOrDefault(p => p.ProductName == selectedProductName);

            if (selectedProduct != null)
            {
                var selectedCategory = categories.FirstOrDefault(c => c.CategoryId == selectedProduct.CategoryId);

                Console.WriteLine($"Selected Product: {selectedProduct.ProductName}");
                Console.WriteLine($"Category: {selectedCategory.CategoryName}");
                Console.WriteLine($"Unit Price: {selectedProduct.UnitPrice}");
                Console.WriteLine($"Units In Stock: {selectedProduct.UnitsInStock}");
            }
            else
            {
                Console.WriteLine("Invalid product name.");
            }

            GetProducts(products);
            GetProductsLinq(products);

            Console.ReadLine();
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var item in products)
            {
                if (item.UnitPrice > 20000 && item.UnitsInStock > 5)
                {
                    filteredProducts.Add(item);
                }

            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            var result = products.Where(p => p.UnitPrice > 20000 && p.UnitsInStock > 5);
            return result.ToList();
        }

        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitsInStock { get; set; }

        }

        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }

        }
    }
}
