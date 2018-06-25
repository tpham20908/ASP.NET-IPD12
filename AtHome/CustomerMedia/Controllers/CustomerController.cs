using CustomerMedia.Models;
using CustomerMedia.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerMedia.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.Membership);
            return View(customers);
        }

        // GET Customer/New
        public ActionResult New()
        {
            var membership = _context.Memberships;

            var vm = new CustomerFormVM
            {
                Customer = new Customer(),
                Memberships = membership
            };

            return View("CustomerForm", vm);
        }
    }
}