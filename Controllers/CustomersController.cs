using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: customers/
        [Route("customers/")]
        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };

            var viewModel = new CustomerViewModel
            {
                Customer = customers
            };

            return View(viewModel);
        }

        // GET: customers/details/id
        [Route("customers/details/{id}")]
        public ActionResult Details()
        {
            
            return View();
        }
    }
}