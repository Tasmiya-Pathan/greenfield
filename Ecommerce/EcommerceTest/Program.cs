using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRM;
//using Catalog;
using OrderProcessing;

namespace EcommerceTest
{
    public class Program
    {
        static void Main(string[] args)
        {

            // For Customer Library
            {
                Customer customer1 = new Customer();        // create object for customer class
                customer1.Id = 101;
                customer1.FirstName = "Tasmiya";
                customer1.LastName = "Pathan";
                customer1.Email = "tp@gmail.com";
                customer1.Contact = "9876564567";

                Customer customer2 = new Customer();         // create object for customer class
                customer2.Id = 102;
                customer2.FirstName = "Supriya";
                customer2.LastName = "Patil";
                customer2.Email = "Sp@gmail.com";
                customer2.Contact = "8767564532";

                ICustomerService customerService = new CustomerService();           // Creating child object with refernce to parent class
                customerService.Insert(customer1);                                  // Polymorphism
                customerService.Insert(customer2);

                //dispay list
                List<Customer> allCustomers = customerService.GetAll();
                foreach (Customer customer in allCustomers)
                {
                    Console.WriteLine(customer.FirstName);
                    Console.WriteLine(customer.LastName);
                    Console.WriteLine(customer.Email);
                    Console.WriteLine(customer.Contact);
                }
            }

            // For Product Library
            /*{
                Product product1 = new Product();
                product1.Id = 12;
                product1.Title = "prod1";
                product1.Description = "this is product 1";
                product1.UnitPrice = 278.67M;
                product1.Quantity = 78;
                product1.ImageUrl = "prod1_img_url.jpg";

                Product product2 = new Product();
                product2.Id = 22;
                product2.Title = "prod2";
                product2.Description = "this is product 2";
                product2.UnitPrice = 678.7M;
                product2.Quantity = 108;
                product2.ImageUrl = "prod2_img_url.jpg";

                IProductService productService = new ProductService(); 
                productService.Insert(product1);   
                productService.Insert(product2);

                List<Product> allProducts = productService.GetAllProducts();
                foreach(Product product in allProducts)
                {
                    Console.WriteLine(product.Id);
                    Console.WriteLine(product.Title);  
                    Console.WriteLine(product.Description);
                    Console.WriteLine(product.UnitPrice);
                    Console.WriteLine(product.Quantity);
                    Console.WriteLine(product.ImageUrl);
                }

                // testing Update method
                {
                    Product product3 = new Product();
                    product3.Id = 22;
                    product3.Title = "prod2";
                    product3.Description = "this is product 2";
                    product3.UnitPrice = 508.7M;
                    product3.Quantity = 108;
                    product3.ImageUrl = "prod2_img_url.jpg";
                    Console.WriteLine(productService.Update(product3));

                    allProducts = productService.GetAllProducts();
                    foreach (Product product in allProducts)
                    {
                        Console.WriteLine(product.Id);
                        Console.WriteLine(product.Title);
                        Console.WriteLine(product.Description);
                        Console.WriteLine(product.UnitPrice);
                        Console.WriteLine(product.Quantity);
                        Console.WriteLine(product.ImageUrl);
                    }
                }
            }*/

            // For OrderProcessing
            Order order1 = new Order();
            order1.Id = 156;
            order1.Date = DateTime.Now;
            order1.Amount = 3453;
            order1.Status = "Shiping";

            Order order2 = new Order();
            order2.Id = 166;
            order2.Date = DateTime.Today;
            order2.Amount = 3453;
            order2.Status = "Pachaging";

            IOrderService orderService = new OrderService();
            orderService.Insert(order1);
            orderService.Insert(order2);

            //dispay list
            List<Order> allOrders = orderService.GetAllOrders();
            foreach(Order order in allOrders)
            {
                Console.WriteLine(order.Date);
                Console.WriteLine(order.Amount);
                Console.WriteLine(order.Status);
            }

            Console.ReadLine();                                             // written to hold the output screen 
        }
    }
}
