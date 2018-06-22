using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Phono.Models;

namespace Phono.Controllers
{
    public class PhoneController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Phone
        public ActionResult Index()
        {
            var phones = db.Phones.Include(p => p.Brand).Include(p => p.PhoneType);
            return View(phones.ToList());
        }

        // GET: Phone/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Phone phone = db.Phones
                .Include(p => p.Brand)
                .Include(p => p.PhoneType)
                .FirstOrDefault(p => p.Id == id);
            if (phone == null)
            {
                return HttpNotFound();
            }
            return View(phone);
        }

        // GET: Phone/Create
        public ActionResult Create()
        {
            var vm = new CreatePhoneVM
            {
                Phone = new Phone(),
                Brands = db.Brands.ToList(),
                PhoneTypes = db.PhoneTypes.ToList()
            };

            return View(vm);
        }

        public ActionResult Save(Phone phone)
        {

            var errors = ModelState.Values.SelectMany(v => v.Errors);

            // check if the form is valid - Sever side validation
            if (!ModelState.IsValid)
            {
                // return same form to user
                var vm = new CreatePhoneVM
                {
                    Phone = phone,
                    Brands = db.Brands.ToList(),
                    PhoneTypes = db.PhoneTypes.ToList()
                };

                return View("Create", vm);
            }

            if (phone.Id == 0)
            {
                db.Phones.Add(phone);
            }
            else
            {
                var phoneInDB = db.Phones.Single(p => p.Id == phone.Id);

                TryUpdateModel(phoneInDB);
            }

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        //Edit
        //[Authorize]
        public ActionResult Edit(int id)
        {
            var phone = db.Phones.FirstOrDefault(p => p.Id == id);

            if (phone == null)
                return HttpNotFound();

            var vm = new CreatePhoneVM
            {
                Phone = phone,
                Brands = db.Brands.ToList(),
                PhoneTypes = db.PhoneTypes.ToList()
            };

            return View("Create", vm);
        }

        // GET: Phone/Delete/5
        //[Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Phone phone = db.Phones
                .Include(p => p.Brand)
                .Include(p => p.PhoneType)
                .SingleOrDefault(p => p.Id == id);

            if (phone == null)
            {
                return HttpNotFound();
            }
            return View(phone);
        }

        // POST: Phone/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Phone phone = db.Phones.Find(id);
            db.Phones.Remove(phone);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
