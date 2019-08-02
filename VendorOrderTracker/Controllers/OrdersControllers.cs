using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

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
    }
}