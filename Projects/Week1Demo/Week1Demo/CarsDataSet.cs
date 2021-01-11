using System;
using System.Collections.Generic;

namespace Week1Demo
{
    public class CarsDataSet
    {
        private List<Car> allCars = new List<Car>();


        public int getNumberOfCars()
        {
            return allCars.Count;
        }

        public void addNewCar(Car car)
        {
            allCars.Add(car);
        }

    }
}
