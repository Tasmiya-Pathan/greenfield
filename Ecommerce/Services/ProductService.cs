using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCOLib;
using Specification;
using BinaryRepositoryLib;
namespace Services
{
    public class ProductService : IProductService
    {
        public bool Seeding()
        {
            bool status = false;
            List<Product> products = new List<Product>();           
            products.Add(new Product { ID = 1, Name = "gerbers", Description = "Wedding flower", UnitPrice = 12, Quantity = 5000, Image = "/Images/gerbera.jpg" });     // object created using Properties 
            products.Add(new Product { ID = 1, Name = "rose", Description = "Valentine flower", UnitPrice = 23, Quantity = 7000, Image = "/images/rose.jpg" });
            products.Add(new Product { ID = 1, Name = "lily", Description = "Delicate flower", UnitPrice = 2, Quantity = 9000, Image = "/images/lily.jpg" });
            products.Add(new Product { ID = 1, Name = "jasmine", Description = "Fragrance flower", UnitPrice = 15, Quantity = 2000, Image = "/images/jasmine.jpg" });
            products.Add(new Product { ID = 1, Name = "lotus", Description = "Workship flower", UnitPrice = 45, Quantity = 1000, Image = "/images/lotus.jpg" });

            IDataRepository repo = new BinaryReopsitory();
            status = repo.Serialize("/Products_data/products.dat", products);
            return status;
        }
        public bool Delete(int id)
        {
            Product theProduct = Get(id);
            if(theProduct != null)
            {
                List<Product> allProduct = GetAll();
                allProduct.Remove(theProduct);
                IDataRepository repo = new BinaryReopsitory();
                repo.Serialize("/Products_data/products.dat", allProduct);
                return true;
            }
            return false;
        }

        public Product Get(int id)
        {
            Product foundProduct = null;
            List<Product> products = GetAll();
            foreach(Product p in products)
            {
                if(p.ID == id)
                {
                    foundProduct = p;
                    break;
                }
            }
            return foundProduct;
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            // call logic of BinaryRepository
            IDataRepository repository = new BinaryReopsitory();
            products = repository.Deserialize("products.dat");
            return products;


            /* hard core coding
            products.Add(new Product { ID = 1, Name = "gerbers", Description = "Wedding flower", UnitPrice = 12, Quantity = 5000, Image = "/Images/gerbera.jpg" });     // object created using Properties 
            products.Add(new Product { ID = 1, Name = "rose", Description = "Valentine flower", UnitPrice = 23, Quantity = 7000, Image = "/images/rose.jpg" });
            products.Add(new Product { ID = 1, Name = "lily", Description = "Delicate flower", UnitPrice = 2, Quantity = 9000, Image = "/images/lily.jpg" });
            products.Add(new Product { ID = 1, Name = "jasmine", Description = "Fragrance flower", UnitPrice = 15, Quantity = 2000, Image = "/images/jasmine.jpg" });
            products.Add(new Product { ID = 1, Name = "lotus", Description = "Workship flower", UnitPrice = 45, Quantity = 1000, Image = "/images/lotus.jpg" });
            */
        }

        public bool Insert(Product productToBeUpdated)
        {
            Product theProduct = Get(productToBeUpdated.ID);
            if (theProduct != null)
            {
                List<Product> allProduct = GetAll();
                allProduct.Remove(theProduct);
                allProduct.Add(productToBeUpdated);
                IDataRepository repo = new BinaryReopsitory();
                repo.Serialize("products.dat", allProduct);
                return true;
            }
            return false;
        }

        public bool Update(Product product)
        {
            return false;
        }
    }
}
