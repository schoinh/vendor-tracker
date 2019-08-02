using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; }
        public int Id { get; set; }
        private static List<Vendor> _instances = new List<Vendor> {};
        private static int _idCount = 1;

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            Orders = new List<Order> {};
            Id = _idCount;
            _instances.Add(this);
            _idCount++;
        }

        public static void ResetIdCount()
        {
            _idCount = 1;
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }
    }
}