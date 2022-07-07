using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CordisCompany.Models;

//The rentItems controller has read/write actions and views and uses Entity framework.
//For this project, I used my local SQL server to create the rentItems table, and the
//messages controller gives the ability to update this using the app.

namespace CordisCompany.Controllers
{
    public class rentItemsController : Controller
    {
        private CordisCompanyEntities db = new CordisCompanyEntities();

        // GET: rentItems
        //All rentItems are returned as a view for the Index() page, which shows a record of all rentalItems
        public ActionResult Index()
        {
            return View(db.rentItems.ToList());        

        }

        public ActionResult Order()
        {
            return View();
        }

        // GET: rentItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rentItem rentItem = db.rentItems.Find(id);
            if (rentItem == null)
            {
                return HttpNotFound();
            }
            return View(rentItem);
        }

        // GET: rentItems/Rent
        //In the Rent() view, POST requests can be made to rentItems in order to add more orders
        public ActionResult Rent()
        {
            return View();
        }

        // POST: rentItems/Rent
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Rent([Bind(Include = "ID,itemName,reach1,reach2,imgString,style,progress")] rentItem rentItem)
        {
            if (ModelState.IsValid)
            {
                db.rentItems.Add(rentItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rentItem);
        }

        // GET: rentItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rentItem rentItem = db.rentItems.Find(id);
            if (rentItem == null)
            {
                return HttpNotFound();
            }
            return View(rentItem);
        }

        // POST: rentItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,itemName,reach1,reach2,imgString,style,progress")] rentItem rentItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rentItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rentItem);
        }

        // GET: rentItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rentItem rentItem = db.rentItems.Find(id);
            if (rentItem == null)
            {
                return HttpNotFound();
            }
            return View(rentItem);
        }

        // POST: rentItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            rentItem rentItem = db.rentItems.Find(id);
            db.rentItems.Remove(rentItem);
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
