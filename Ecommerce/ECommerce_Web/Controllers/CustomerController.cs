﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM;
namespace ECommerce_Web.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ICustomerService customerService = new CustomerService();   
            List<Customer> customerList = customerService.GetAll();
            return View(customerList);
        }
    }
}