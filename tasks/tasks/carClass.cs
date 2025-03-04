using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    public class Car : Engine {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Car(string brand, string model, int year,int horsePower,string fuelType) : base(horsePower, fuelType) {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public void StartCar() {
            Console.WriteLine($@"Car is starting..
Brand: {Brand}
Model: {Model}
Year: {Year}
Fuel type: {FuelType}
Horse power: {HorsePower}");
        }
    }
}
