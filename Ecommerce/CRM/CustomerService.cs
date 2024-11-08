using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class CustomerService : ICustomerService         // Inheritance of interface class 
    {
       /* List<Customer> _customerList;     */                 // list to maintain objects

        /*public CustomerService() 
        {
            _customerList = new List<Customer>();   // when created the object add it to the list.
        }*/
        public bool Delete(int id)                        // Function to delete object
        {
            return false;
            /*Customer theCustomer = this.Get(id);
            return this._customerList.Remove(theCustomer);*/
        }

        public Customer Get(int id)                        // Function to get object by ID
        {
            return new Customer { Id = 678, FirstName = "Ashrit", LastName = "Vanshi", Contact = "9908431874", Email = "ashrit.vanshi@gmail.com" };
            /*foreach(Customer customer in _customerList) 
            {
                if(customer.Id == id)
                    return customer;  
            }
            return null;*/
        }

        public List<Customer> GetAll()                       // Function to get all object
        {
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { Id = 344, FirstName = "Supriya", LastName = "Patil", Contact = "9956879876", Email = "supriya.patil@gmail.com" });
            customer.Add(new Customer { Id = 374, FirstName = "Ethan", LastName = "Leo", Contact = "9878676545", Email = "ethan.leo@gmail.com" });
            customer.Add(new Customer { Id = 456, FirstName = "Meera", LastName = "Singh", Contact = "8798675429", Email = "meera.singh@gmail.com" });
            customer.Add(new Customer { Id = 678, FirstName = "Ashrit", LastName = "Vanshi", Contact = "9908431874", Email = "ashrit.vanshi@gmail.com" });
            return customer;
            /*return _customerList;*/
        }

        public bool Insert(Customer customer)               // Function to insert object
        {
            /*this._customerList.Add(customer);*/
            return true;
        }

        public bool Update(Customer customer)               // Function to update object
        {
            /*Customer thecustomer = this.Get(customer.Id);
            thecustomer.FirstName = customer.FirstName;
            thecustomer.LastName = customer.LastName;
            thecustomer.Email = customer.Email;
            thecustomer.Contact = customer.Contact;*/
            return true;

            //this._customerList.Remove(thecustomer);      
            //this._customerList.Add(customer);

        
        }
    }
}
