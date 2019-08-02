using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor.Find(vendorId);
            return View(Vendor.FoundVendor);
        }

        // [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
        // public ActionResult Show()
        // {
        //     // List<Item> allItems = Item.GetAll();
        //     // return View(allItems);
        // }

        // [HttpGet("/orders/new")]
        // public ActionResult New()
        // {
        //     return View();
        // }

        // [HttpPost("/orders")]
        // public ActionResult Create(string description)
        // {
        //     // Item myItem = new Item(description);
        //     return RedirectToAction("Index");
        // }

        // [HttpPost("/orders/delete")]
        // public ActionResult DeleteAll()
        // {
        //     // Item.ClearAll();
        //     return View();
        // }
        // [HttpGet("/orders/{id}")]
        // public ActionResult Show(int id)
        // {
        //     // Item foundItem = Item.Find(id);
        //     // return View(foundItem);
        // }
    }
}