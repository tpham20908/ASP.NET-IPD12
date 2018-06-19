using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using VidPlace.ViewModels;

namespace VidPlace.Controllers
{
    public class MediaController : Controller
    {
        // DbContext
        private ApplicationDbContext _context;

        // constructor
        public MediaController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Media
        public ActionResult Index()
        {
            
            var customers = GetCustomer();
            //var customers = new List<Customer>();

            // var media = new Media() { Name = "Avengers" };

            // var model = new RentalMediaVM() { Media = media, Customers = customers };

            return View(customers);
        }

        public ActionResult Detail(int id)
        {
            Customer customer = GetCustomer().FirstOrDefault(c => c.ID == id);
            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }

        public ActionResult getallmedia()
        {
            var model = GetMedia();
            return View(model);
        }

        public ActionResult detailmedia(int id)
        {
            var model = GetMedia().FirstOrDefault(m => m.Id == id);
            return View(model);
        }

        public IEnumerable<Customer> GetCustomer()
        {
            var customers = _context.Customers.ToList();
            /*
            var customers = new List<Customer>
            {
                new Customer() { ID = 1, Name = "Iron Man" },
                new Customer() { ID = 2, Name = "Spider Man" },
                new Customer() { ID = 3, Name = "Spider Girl" },
                new Customer() { ID = 4, Name = "Batman" },
                new Customer() { ID = 5, Name = "Batgirl" }
            };
            */
            return customers;
        }

        public IEnumerable<Media> GetMedia()
        {
            var media = new List<Media>
            {
                new Media() { Id = 1, Name = "Iron Man 2.3", RentDate = DateTime.Now.AddDays(-2) },
                new Media() { Id = 1, Name = "Spider Man 3.2", RentDate = DateTime.Now.AddDays(-3) },
                new Media() { Id = 1, Name = "Batman 2.1", RentDate = DateTime.Now.AddDays(-5) },
            };
            return media;
        }
    }
}