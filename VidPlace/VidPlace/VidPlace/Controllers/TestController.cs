using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using VidPlace.ViewModels;

namespace VidPlace.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public string msg()
        {
            return "<img src=\"../../images/stop.png\">";
        }

        public Customer customer(int id)
        {
            Customer c = new Customer()
            {
                ID = id,
                Name = "Justin Trudeau"
            };

            return c;
        }

        public ActionResult random(int id)
        {
            var media = new Media();
            media.Id = id;
            media.Name = "Gone with the wind";
            media.RentDate = DateTime.Now.AddDays(-2);
            media.ImageUrl = "../../images/gwtw.jpg";
            return View(media);
        }

        //https://bootswatch.com/3/

        public ActionResult ex1()
        {
            //return Content("<h3><em>This is Content type return.</em></h3>");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
            //return RedirectToAction("Action", "Controller", new { model });
            //return RedirectToAction("Action", "Controller", new { parameter });
            return RedirectToAction("random", new { id = 10005 });

            //return RedirectToAction("random", "test", new { userName = "Alex123" });
        }

        public ActionResult edit(int id)
        {
            return Content("Provided ID: " + id);
        }

        [Route("test/ex2/{pageIndex:range(2000,2010)}/{sortby?}")]
        public ActionResult ex2(int? pageIndex, string sortby)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrEmpty(sortby))
                sortby = "name";
            return Content("Page #" + pageIndex + ", sortby: " + sortby);
        }

        [Route("Test/release/{year:range(2018, 2028)}/{month:range(1,12)}")]
        public ActionResult release(int year, int month)
        {
            return Content("Year: " + year + ", Month: " + month);
        }

        public ActionResult rental()
        {
            var media = new Media() { Name = "Avengers" };

            var customer = new List<Customer>
            {
                new Customer() { Name = "Iron Man" },
                new Customer() { Name = "Spider Man" },
                new Customer() { Name = "Spider Girl" }
            };

            var model = new RentalMediaVM() { Media = media, Customers = customer };

            return View(model);
        }
    }
}