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

        [HttpGet("/vendors/{vendorId}")]
        public ActionResult Show(int vendorId)
        {
            Vendor.Find(vendorId);

            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("vendor", Vendor.FoundVendor);
            model.Add("orders", Vendor.FoundVendor.Orders);

            return View(model);
        }

        [HttpPost("/vendors/{vendorId}")]
        public ActionResult Update(int vendorId, string name, string description)
        {
            Vendor.Find(vendorId);

            Vendor.FoundVendor.Name = name;
            Vendor.FoundVendor.Description = description;

            return RedirectToAction("Show");
        }

        [HttpGet("/vendors/{vendorId}/edit")]
        public ActionResult Edit(int vendorId)
        {
            Vendor.Find(vendorId);
            return View(Vendor.FoundVendor);
        }

        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string title, string description, int price, string date)
        {
            Vendor.Find(vendorId);
            Order newOrder = new Order(title, description, price, date);
            Vendor.FoundVendor.AddOrder(newOrder);

            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("vendor", Vendor.FoundVendor);
            model.Add("orders", Vendor.FoundVendor.Orders);

            return View("Show", model);
        }
    }
}