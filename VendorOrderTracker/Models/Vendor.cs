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
        public static Vendor FoundVendor { get; set; }
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

        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public static void Find(int uniqueId)
        {
            for (int i = 0; i < _instances.Count; i++)
            {
                if (_instances[i].Id == uniqueId)
                {
                    FoundVendor = _instances[i];
                }
            }
        }

        public void AddOrder(Order newOrder)
        {
            Orders.Add(newOrder);
        }

        public static void DeleteAll()
        {
            _instances.Clear();
        }

        public static void ResetIdCount()
        {
            _idCount = 1;
        }
    }
}