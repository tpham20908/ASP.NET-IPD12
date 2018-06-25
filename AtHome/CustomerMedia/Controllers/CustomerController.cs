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
        public ActionResult Index(string SearchString)
        {
            var customers = _context.Customers.Include(c => c.Membership);
            if (!string.IsNullOrWhiteSpace(SearchString))
                customers = customers.Where(c => c.Name.Contains(SearchString));

            return View(customers);
        }

        // GET Customer/New
        public ActionResult New()
        {
            var memberships = _context.Memberships;

            var vm = new CustomerFormVM
            {
                Customer = new Customer(),
                Memberships = memberships
            };

            return View("CustomerForm", vm);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            // ModelState not valid
            if (!ModelState.IsValid)
            {
                var vm = new CustomerFormVM
                {
                    Customer = customer,
                    Memberships = _context.Memberships
                };

                return View("CustomerForm", vm);
            }

            // ModelState is valid
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDB = _context.Customers.FirstOrDefault(c => c.Id == customer.Id);
                customerInDB.Name = customer.Name;
                customerInDB.Birthdate = customer.Birthdate;
                customerInDB.Address = customer.Address;
                customerInDB.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
                customerInDB.MembershipId = customer.MembershipId;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        // GET: Customer/Edit/2
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var memberships = _context.Memberships;

            var vm = new CustomerFormVM
            {
                Customer = customer,
                Memberships = memberships
            };

            return View("CustomerForm", vm);
        }

        public ActionResult Delete(int? id)
        {
            Customer customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Customer customer = _context.Customers.Find(id);

            _context.Customers.Remove(customer);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}