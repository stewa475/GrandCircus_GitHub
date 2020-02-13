using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._3_Used_Car_Lot
{
    class UsedCar : Car
    {
        private double mileage;

        public double Mileage { get => mileage; set => mileage = value; }

        public UsedCar() : base()
        {
            this.mileage = 0.0;
        }
        public UsedCar(int vin, string make, string model, int year, double price, double mileage) : base (vin, make, model, year, price)
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMileage {mileage}";
        }
    }
}
