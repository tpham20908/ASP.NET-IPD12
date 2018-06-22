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


        // POST: Phone/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PhoneName,DateReleased,ScreenSize,ImageUrl,BrandId,PhoneTypeId")] Phone phone)
        {
            if (ModelState.IsValid)
            {
                db.Phones.Add(phone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BrandId = new SelectList(db.Brands, "Id", "BrandName", phone.BrandId);
            ViewBag.PhoneTypeId = new SelectList(db.PhoneTypes, "Id", "Type", phone.PhoneTypeId);
            return View(phone);
        }

        // GET: Phone/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Phone phone = db.Phones.Find(id);
        //    if (phone == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.BrandId = new SelectList(db.Brands, "Id", "BrandName", phone.BrandId);
        //    ViewBag.PhoneTypeId = new SelectList(db.PhoneTypes, "Id", "Type", phone.PhoneTypeId);
        //    return View(phone);
        //}

        // POST: Phone/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PhoneName,DateReleased,ScreenSize,ImageUrl,BrandId,PhoneTypeId")] Phone phone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phone).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BrandId = new SelectList(db.Brands, "Id", "BrandName", phone.BrandId);
            ViewBag.PhoneTypeId = new SelectList(db.PhoneTypes, "Id", "Type", phone.PhoneTypeId);
            return View(phone);
        }

        // GET: Phone/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Phone phone = db.Phones.Find(id);
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
