using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._3_Used_Car_Lot
{
    class Car
    {
        private int vin;
        private string make;
        private string model;
        private int year;
        private double price;

        public int Vin { get => vin; set => vin = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public Car()
        {
            this.vin = 10000;
            this.make = "";
            this.model = "";
            this.year = 0;
            this.price = 0.0;
        }
        public Car(int vin, string make, string model, int year, double price)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        {
            this.vin = vin;
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Vin: {vin}\nMake: {make}\nModel: {model}\nYear: {year}\nPrice: {price}";
        }
    }
}
