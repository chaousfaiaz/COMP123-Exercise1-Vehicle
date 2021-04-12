using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Warranty { get; set; }
        public string Store { get; set; }

        public Vehicle(string name,
            string brand,
            double price,
            int warranty,
            string store)
        {
            Name = name;
            Brand = brand;
            Price = price;
            Warranty = warranty;
            Store = store;
        }

        public abstract string Operate();
    }
}
