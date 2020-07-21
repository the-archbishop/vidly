﻿using System;
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
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }

        // GET: customers/
        [Route("customers/")]
        public ActionResult Customers()
        {
            var customers = _context.Customers.ToList();

            var viewModel = new CustomerViewModel
            {
                Customer = customers
            };

            return View(viewModel);
        }

        // GET: customers/details/id
        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {

            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);


            if (customer == null)
                return HttpNotFound();


            return View(customer);
        }
    }
}