using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
    [TestClass]
    public class VendorTest : IDisposable
    {
        public void Dispose()
        {
            Vendor.ResetIdCount();
        }

        [TestMethod]
        public void VendorConstructor_CreatesNewVendor_Vendor()
        {
            Vendor newVendor = new Vendor("5 Stones Coffee", "Coffee place in downtown Redmond");

            Assert.AreEqual("5 Stones Coffee", newVendor.Name);
        }

        [TestMethod]
        public void VendorConstructor_CreatesUniqueId_Int()
        {
            Vendor newVendor1 = new Vendor("5 Stones Coffee", "Coffee place in downtown Redmond");
            Vendor newVendor2 = new Vendor("Waffle House", "Breakfast chain");

            Assert.AreEqual(1, newVendor1.Id);
            Assert.AreEqual(2, newVendor2.Id);
        }

        // [TestMethod]
        // public void VendorConstructor_CreatesUniqueId_Int()
        // {
        //     Vendor newVendor1 = new Vendor("5 Stones Coffee", "Coffee place in downtown Redmond");
        //     Vendor newVendor2 = new Vendor("Waffle House", "Breakfast chain");

        //     Assert.AreEqual(1, newVendor1.Id);
        //     Assert.AreEqual(2, newVendor2.Id);
        // }
    }
}