using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCodeFirtsDemo.Models;
using System.Data.Entity;

namespace EFCodeFirtsDemo.Controllers
{
    public class HomeController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Employees.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {

            if (ModelState.IsValid == true)
            {
                db.Employees.Add(e);
                int rowcount = db.SaveChanges();
                if (rowcount > 0)
                {
                    // ViewBag.InsertMessage = "<script>alert('Data Inserted Successfully')";
                    TempData["InsertMessage"] = "<script>alert('Data Inserted Successfully')</script>";
                    return RedirectToAction("Index");
                   // ModelState.Clear();
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Data Not Inserted')";
                   
                }
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var detailrow = db.Employees.Where(model => model.Id == id).FirstOrDefault();
            return View(detailrow);
        }
        public ActionResult Edit(int id)
        {
            var row = db.Employees.Where(model => model.Id == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            if (ModelState.IsValid == true)
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
                    ViewBag.UpdateMessage = "<script>alert('Data Not Updated')</script>";

                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var deleterow = db.Employees.Where(model => model.Id == id).FirstOrDefault();
            return View(deleterow);
        }

        [HttpPost]
        public ActionResult Delete(Employee e)
        {
            db.Entry(e).State = EntityState.Deleted;
            int rowcount = db.SaveChanges();
            if (rowcount > 0)
            {
                TempData["DeleteMessage"] = "<script>alert('Data Deleted Successfully')</script>";
                
            }
            else
            {
                TempData["DeleteMessage"] = "<script>alert('Data Not Deleted')</script>";

            }
            return RedirectToAction("Index");
        }
    }
}