using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Tests
{
    [TestClass]
    public class VendorTest : IDisposable
    {
        public void Dispose()
        {
            Vendor.ResetIdCount();
            Vendor.DeleteAll();
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

        [TestMethod]
        public void GetAll_RetrievesAllVendors_ListOfVendors()
        {
            Vendor newVendor1 = new Vendor("5 Stones Coffee", "Coffee place in downtown Redmond");
            Vendor newVendor2 = new Vendor("Waffle House", "Breakfast chain");

            List<Vendor> vendorList = Vendor.GetAll();

            Assert.AreEqual("Breakfast chain", vendorList[1].Description);
        }

        [TestMethod]
        public void Find_FindsVendorById_FoundVendor()
        {
            Vendor newVendor1 = new Vendor("5 Stones Coffee", "Coffee place in downtown Redmond");
            Vendor newVendor2 = new Vendor("Waffle House", "Breakfast chain");

            Vendor.Find(2);

            Assert.AreEqual("Waffle House", Vendor.FoundVendor.Name);
        }
    }
}