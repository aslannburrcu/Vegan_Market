using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.Validation;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vegan_Market.Models;

namespace Vegan_Market.Controllers
{
    public class BrandController : Controller
    {
       Aslan_Commerce_vtEntities db = new Aslan_Commerce_vtEntities();

        // GET: Brand
        public async Task<ActionResult> Index()
        {
            return View(await db.Brand.ToListAsync());
        }

        // GET: Brand/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand brand = await db.Brand.FindAsync(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }

        // GET: Brand/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Brand/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "brand_id,brand_name")] Brand brand)
        {
                if (ModelState.IsValid)
                {
                    db.Brand.Add(brand);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            
            return View(brand);
        }

        // GET: Brand/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand brand = await db.Brand.FindAsync(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }

        // POST: Brand/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "brand_id,brand_name")] Brand brand)
        {
            brand.brand_name = brand.brand_name;

                if (ModelState.IsValid)
                {
                    db.Entry(brand).State = EntityState.Modified;
                 
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }
            return View(brand);
                }
            
           /* return View(brand);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var brandupdate = db.Brand.Find(id);
            if (TryUpdateModel(brandupdate, "", new string[] { "brand_name"}))
            {
                try {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (DataException /* dex 
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }*/
            
  // GET: Brand/Delete/5
     
        public async Task<ActionResult> Delete(int? id)
        {
            
                Brand brand = await db.Brand.FindAsync(id);
                db.Brand.Remove(brand);
                await db.SaveChangesAsync();
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
