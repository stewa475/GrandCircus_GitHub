using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._3_UCL
{
    class UsedCar : Car
    {
        private double mileage;

        public double Mileage { get => mileage; set => mileage = value; }

        public UsedCar() : base()
        {
            this.mileage = 0.0;
        }
        public UsedCar(string make, string model, int year, double price, double mileage) : base(make, model, year, price)
        {
            this.Vin = RandomString(5);
            this.mileage = mileage;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMileage {mileage}";
        }
    }
}
