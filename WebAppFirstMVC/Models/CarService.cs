using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirstMVC.Models
{
    public class CarService
    {
        static int idCounter;
        static List<Car> carList = new List<Car>() 
        {
            new Car() { id = ++idCounter, Brand = "Opel", ModelName = "Corsa 1.6"},
            new Car() { id = ++idCounter, Brand = "SAAB", ModelName = "9-5"},
            new Car() { id = ++idCounter, Brand = "Nissan", ModelName = "Almera 1.6"},
        };

        public void Add(string brand, string modelName)
        {
            carList.Add(new Car() { id = ++idCounter, Brand = brand, ModelName = modelName });
        }

        public List<Car> All()
        {
            return carList;
        }
    }
}
