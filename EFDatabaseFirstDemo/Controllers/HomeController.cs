using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDatabaseFirstDemo.Models;

namespace EFDatabaseFirstDemo.Controllers
{
    
    public class HomeController : Controller
    {
        EFDatabaseCrudEMP2Entities1 db = new EFDatabaseCrudEMP2Entities1();
        // GET: Home
        public ActionResult Index()
        {
            //var skip = 1;
            var data = db.EMPs.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EMP e)
        {
            if (ModelState.IsValid == true)
            {
                db.EMPs.Add(e);
                int rowcount = db.SaveChanges();
                if (rowcount > 0)
                {
                    TempData["InsertMessage"] = "<script>alert('Data Inserted Successfully')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["InsertMessage"] = "<script>alert('Data Not Inserted ')</script>";
                }
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var detailsrow = db.EMPs.Where(model => model.id == id).FirstOrDefault();
            return View(detailsrow);
        }
        public ActionResult Edit(int id)
        {
            var editrow = db.EMPs.Where(model => model.id == id).FirstOrDefault();
            return View(editrow);
        }

        [HttpPost]
        public ActionResult Edit(EMP e)
        {
            if(ModelState.IsValid == true)
            {
                db.Entry(e).State = EntityState.Modified;
                int rowcount = db.SaveChanges();
                if (rowcount > 0)
                {
                    TempData["UpdateMessage"] = "<script>alert('Data Updated Successfully')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["UpdateMessage"] = "<script>alert('Data Not Updated ')</script>";
                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var deleterow = db.EMPs.Where(model => model.id == id).FirstOrDefault();
            return View(deleterow);
        }

        [HttpPost]
        public ActionResult Delete(EMP e)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(e).State = EntityState.Deleted;
                int rowcount = db.SaveChanges();
                if (rowcount > 0)
                {
                    TempData["DeleteMessage"] = "<script>alert('Data Deleted Successfully')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["DeleteMessage"] = "<script>alert('Data Not Deleted ')</script>";
                }
            }
            return View();
        }
    }
}