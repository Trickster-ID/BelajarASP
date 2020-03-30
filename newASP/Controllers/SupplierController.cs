using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using newASP.MyContext;
using newASP.Models;
using System.Data.Entity;

namespace newASP.Controllers
{
    public class SupplierController : Controller
    {
        
        // GET: Supplier
        public ActionResult Index()
        {
            using (myContext connection = new myContext())
            {
                return View(connection.Suppliers.ToList());
            }
        }

        //public ActionResult List()
        //{
        //    myContext connection = new myContext();
        //    List<Supplier> userlist = new List<Supplier>();
        //    userlist = connection.Suppliers.ToList();
        //    return new JsonResult { Data = userlist, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        //}

        // GET: Supplier/Details/5
        public ActionResult Details(int id)
        {
            myContext connection = new myContext();
            return View(connection.Suppliers.Where(x => x.Id == id).FirstOrDefault());
        }

        // GET: Supplier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supplier/Create
        [HttpPost]
        public ActionResult Create(Supplier supplier)
        {
            try
            {
                using (myContext connection = new myContext())
                {
                    connection.Suppliers.Add(supplier);
                    connection.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Edit/5
        public ActionResult Edit(int id)
        {
            myContext connection = new myContext();
            return View(connection.Suppliers.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: Supplier/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Supplier supplier)
        {
            try
            {
                // TODO: Add update logic here
                using (myContext connection = new myContext())
                {
                    connection.Entry(supplier).State = EntityState.Modified;
                    connection.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Delete/5
        public ActionResult Delete(int id)
        {
            myContext connection = new myContext();
            return View(connection.Suppliers.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: Supplier/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (myContext connection = new myContext())
                {
                    Supplier supplier = connection.Suppliers.Where(x => x.Id == id).FirstOrDefault();
                    connection.Suppliers.Remove(supplier);
                    connection.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
