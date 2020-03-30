using newASP.Models;
using newASP.MyContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newASP.Controllers
{
    public class ItemController : Controller
    {
        myContext connection = new myContext();
        // GET: Item
        public ActionResult Index()
        {
            return View(connection.Items.ToList());
        }

        // GET: Item/Details/5
        public ActionResult Details(int id)
        {
            return View(connection.Items.Where(x => x.Id == id).FirstOrDefault());
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(connection.Suppliers, "Id", "Name");//the soure of dropdownlist
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name, Price, Stock, Supplierid")]Item item)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add insert logic here
                connection.Items.Add(item);
                connection.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(connection.Suppliers, "Id", "Name", item.Supplier);
            return View(item);
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Id = new SelectList(connection.Suppliers, "Id", "Name");
            return View(connection.Items.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: Item/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Item item)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add update logic here
                connection.Entry(item).State = EntityState.Modified;
                connection.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(connection.Suppliers, "Id", "Name", item.Supplier);
            return View();
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int id)
        {
            return View(connection.Items.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: Item/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Item item = connection.Items.Where(x => x.Id == id).FirstOrDefault();
                connection.Items.Remove(item);
                connection.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
