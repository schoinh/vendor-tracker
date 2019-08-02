using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string name, string description)
        {
            Vendor newVendor = new Vendor(name, description);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Vendor.Find(id);
            return View(Vendor.FoundVendor);
        }

        // [HttpPost("/vendors/delete")]
        // public ActionResult DeleteAll()
        // {
        //     // Vendor.ClearAll();
        //     return View();
        // }
    }
}