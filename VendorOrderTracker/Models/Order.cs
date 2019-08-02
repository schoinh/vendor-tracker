using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }
        public bool Paid { get; set; }
        public bool Delivered { get; set; }
        public int Id { get; }
        public static Order FoundOrder { get; set; }
        private static List<Order> _instances = new List<Order> {};
        private static int _idCount = 1;

        public Order(string title, string description, int price, string date, bool paid)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            Paid = paid;
            Delivered = false;
            Id = _idCount;
            _instances.Add(this);
            _idCount++;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void Find(int uniqueId)
        {
            for (int i = 0; i < _instances.Count; i++)
            {
                if (_instances[i].Id == uniqueId)
                {
                    FoundOrder = _instances[i];
                }
            }
        }

        public static void ResetIdCount()
        {
            _idCount = 1;
        }
    }
}