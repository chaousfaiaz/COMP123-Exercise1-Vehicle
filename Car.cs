using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Car : Vehicle
    {
        public int NumberOfPassengers { get; set; }

        //Gas / Diesel / Electric / Hybrid
        public string Fuel { get; set; }

        //constructor
        public Car(string name,
            string brand,
            double price,
            int warranty,
            string store,
            int numberOfPassengers,
            string fuel) :
            base(name, brand, price, warranty, store)
        {
            NumberOfPassengers = numberOfPassengers;
            Fuel = fuel;
        }

        public override string Operate()
        {
            return "You turn on the ignition!";
        }


    }
}
