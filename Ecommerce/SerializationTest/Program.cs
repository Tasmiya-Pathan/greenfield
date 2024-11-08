using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCOLib;
using Services;
namespace SerializationTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            productService.Seeding();
            List<Product> allProducts = productService.GetAll();
            foreach (Product product in allProducts)
            {
                Console.WriteLine(product.Name +  " " + product.UnitPrice );
            }
            Console.ReadLine();
        }
    }
}
