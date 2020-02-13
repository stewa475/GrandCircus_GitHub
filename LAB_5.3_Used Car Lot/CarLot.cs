using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._3_Used_Car_Lot
{
    class CarLot
    {
        private List<Car> cars;

        public CarLot()
        {
            
            this.cars = new List<Car>();
        }

        public void AddCar(Car c)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                
                cars.Add(c);
                cars[i].Vin++;
            }
        }
        public void RemoveCar(int vin)
        {
            //int count = 1;
            //for (int i = 0; i < cars.Count; i++)
            //{
            //    //if (cars == vin)
            //    //{

            //    //}
            //}
        }
        public void ViewCars()
        {
            foreach (Car c in cars)
            {
                Console.WriteLine("=======================");
                Console.WriteLine(c);
                Console.WriteLine("=======================");
            }
        }
    }
}
