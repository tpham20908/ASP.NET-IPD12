using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using VidPlace.ViewModels;
using System.Data.Entity;

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

        // Get: Media
        public ActionResult getmedia()
        {
            var media = _context.Medias.ToList();
            return View(media);
        }

        // Get: detailmedia
        public ActionResult detailmedia(int id)
        {
            var model = _context.Medias
                .Include(m => m.Genres)
                .Include(m => m.MediaType)
                .FirstOrDefault(m => m.Id == id);

            if (model == null)
                return HttpNotFound();
            else
                return View(model);
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(cust => cust.Membership).ToList();
            //var customers = GetCustomer();
            //var customers = new List<Customer>();

            // var media = new Media() { Name = "Avengers" };

            // var model = new RentalMediaVM() { Media = media, Customers = customers };

            return View(customers);
        }

        public ActionResult Detail(int id)
        {
            // Customer customer = GetCustomer().FirstOrDefault(c => c.ID == id);

            Customer customer = _context.Customers
                .Include(cust => cust.Membership)
                .FirstOrDefault(cust => cust.ID == id);
            
            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }

        public ActionResult NewCustomer()
        {
            var model = new CustomerMembershipVM()
            {
                Customer = new Customer(),
                Memberships = _context.Memberships.ToList()
            };
            return View(model);
        }

        // saving action into DB
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            // check if the form is valid - Sever side validation
            if (!ModelState.IsValid)
            {
                // return same form to user
                var vm = new CustomerMembershipVM
                {
                    Customer = customer,
                    Memberships = _context.Memberships.ToList()
                };

                return View("NewCustomer", vm);
            }

            if (customer.ID == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDB = _context.Customers.Single(c => c.ID == customer.ID);

                //TryUpdateModel(customerInDB);

                // Update manualy
                customerInDB.Name = customer.Name;
                customerInDB.Address = customer.Address;
                customerInDB.Birthdate = customer.Birthdate;
                customerInDB.IsSubcribedToNewsLetter = customer.IsSubcribedToNewsLetter;
                customerInDB.MembershipId = customer.MembershipId;
            }
            _context.SaveChanges();

            //return RedirectToAction("Index", "Media); 
            return RedirectToAction("Index");
        }

        //Edit
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.ID == id);

            if (customer == null)
                return HttpNotFound();

            var vm = new CustomerMembershipVM
            {
                Customer = customer,
                Memberships = _context.Memberships.ToList()
            };

            return View("NewCustomer", vm);
        }

        // new Media
        public ActionResult NewMedia()
        {
            var genres = _context.Genres;
            var mediaTypes = _context.MediaTypes;
            var vm = new MediaVM
            {
                Media = new Media(),
                Genres = genres,
                MediaTypes = mediaTypes
            };

            return View(vm);
        }

        /*
        public ActionResult getallmedia()
        {
            var model = GetMedia();
            return View(model);
        }

        

        public IEnumerable<Customer> GetCustomer()
        {
            var customers = _context.Customers.ToList();
            
            var customers = new List<Customer>
            {
                new Customer() { ID = 1, Name = "Iron Man" },
                new Customer() { ID = 2, Name = "Spider Man" },
                new Customer() { ID = 3, Name = "Spider Girl" },
                new Customer() { ID = 4, Name = "Batman" },
                new Customer() { ID = 5, Name = "Batgirl" }
            };
            
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
        */
    }
}