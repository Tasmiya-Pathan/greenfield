using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POCOLib;
using Services;
using Specification;
namespace ECommerce_Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            IProductService productService = new ProductService();
            ProductService psvc = (ProductService)productService;          // Downcasting interface object to service object
            // unauthorized access exception then add relative path of products.dat 
            List<Product> products = psvc.GetAll();
            return View(products);
        }

        public ActionResult Details() 
        {
            return View();
        }

        public ActionResult Insert()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}