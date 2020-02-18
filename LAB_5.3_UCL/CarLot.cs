using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._3_UCL
{
    class CarLot
    {
        private List<Car> cars;

        public CarLot()
        {
            this.cars = new List<Car>();
        }

        public List<Car> Cars { get => cars; set => cars = value; }

        public void AddCar(Car c)
        {
            cars.Add(c);

        }

        public void RemoveCar(Car c)
        {
            cars.Remove(c);
        }

        public void ViewCars()
        {
            foreach (Car c in Cars)
            {
                Console.WriteLine("=======================");
                Console.WriteLine(c.ToString());
                Console.WriteLine("=======================");
            }
        }
    }
}
